using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class LinkConverter : JsonConverter<Link?>
{
    public override Link? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        if (value is null) return null;
        if (value.StartsWith("{"))
        {
            return Deserialize<Link>(value);
        }
        return new Link { Href = new Uri(value) };
    }

    public override void Write(Utf8JsonWriter writer, Link? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
