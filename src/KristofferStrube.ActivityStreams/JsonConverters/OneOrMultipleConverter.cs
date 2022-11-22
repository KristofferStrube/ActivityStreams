using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class OneOrMultipleConverter<T> : JsonConverter<IEnumerable<T>?>
{
    public override IEnumerable<T>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out var doc))
        {
            if (doc.RootElement.ValueKind is JsonValueKind.Array)
            {
                return doc.RootElement.EnumerateArray().Select(element => element.Deserialize<T>()!);
            }
            return Enumerable.Range(0,1).Select(_ => doc.Deserialize<T>()!);
        }
        throw new JsonException("Could not be parsed as a JsonDocument.");
    }

    public override void Write(Utf8JsonWriter writer, IEnumerable<T>? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
