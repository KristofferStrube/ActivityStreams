using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

public class OneOrMultipleConverter<T> : JsonConverter<IEnumerable<T>?>
{
    public override IEnumerable<T>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out JsonDocument? doc))
        {
            if (doc.RootElement.ValueKind is JsonValueKind.Array)
            {
                return doc.RootElement.EnumerateArray().Select(element => element.Deserialize<T>()!);
            }
            return Enumerable.Range(0, 1).Select(_ => doc.Deserialize<T>()!);
        }
        throw new JsonException("Could not be parsed as a JsonDocument.");
    }

    public override void Write(Utf8JsonWriter writer, IEnumerable<T>? value, JsonSerializerOptions options)
    {
        if (value?.Count() is 1)
        {
            writer.WriteRawValue(Serialize(value.First(), options));
        }
        else if (value is not null)
        {
            writer.WriteRawValue(Serialize(value, options));
        }
    }
}
