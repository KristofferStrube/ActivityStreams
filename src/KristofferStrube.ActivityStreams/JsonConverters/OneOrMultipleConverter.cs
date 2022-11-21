using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class OneOrMultipleConverter<T> : JsonConverter<IEnumerable<T>?>
{
    public override IEnumerable<T>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        if (value is null) return null;

        if (value.StartsWith('['))
        {
            return Deserialize<IEnumerable<T>>($"\"{value}\"", options);
        }
        else
        {
            var element = Deserialize<T>($"\"{value}\"", options);
            if (element is null) return null;
            return new List<T>() { element };
        }
    }

    public override void Write(Utf8JsonWriter writer, IEnumerable<T>? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
