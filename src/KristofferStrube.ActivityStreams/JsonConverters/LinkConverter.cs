using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class LinkConverter : JsonConverter<ILink?>
{
    public override ILink? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out var doc))
        {
            if (doc.RootElement.ValueKind == JsonValueKind.String)
            {
                return new Link { Href = doc.Deserialize<Uri>(options) };
            }
            else if (doc.RootElement.TryGetProperty("type", out var type))
            {
                return type.GetString() switch
                {
                    "Link" => doc.Deserialize<Link>(),
                    _ => throw new JsonException("JSON element was not a Link."),
                };
            }
            throw new JsonException("JSON element did not have a type property nor was it a string.");
        }
        throw new JsonException("Could not be parsed as a JsonDocument.");
    }

    public override void Write(Utf8JsonWriter writer, ILink? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
