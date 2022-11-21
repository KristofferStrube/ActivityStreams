using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class OneOrMultipleConverter<T> : JsonConverter<IEnumerable<T>?>
{
    public override IEnumerable<T>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.StartArray)
        {
            return Deserialize<IEnumerable<T>>($"\"{reader.GetString()!}\"", options);
        }
        else
        {
            var element = Deserialize<T>($"\"{reader.GetString()!}\"", options);
            if (element is null) return null;
            return new List<T>() { element };
        }
    }

    public override void Write(Utf8JsonWriter writer, IEnumerable<T>? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
