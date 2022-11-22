using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class ObjectOrLinkConverter : JsonConverter<ObjectOrLink?>
{
    public override ObjectOrLink? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out var doc))
        {
            if (doc.RootElement.ValueKind == JsonValueKind.String)
            {
                return (new LinkConverter()).Read(ref reader, typeof(Link), options);
            }
            else if (doc.RootElement.TryGetProperty("type", out var type))
            {
                return type.GetString() switch {
                    "Link" => (new LinkConverter()).Read(ref reader, typeof(Link), options),
                    // Objects
                    "Document" => doc.Deserialize<Document>(options),
                    "Image" => doc.Deserialize<Image>(options),
                    "Note" => doc.Deserialize<Note>(options),
                    // Actors
                    "Person" => doc.Deserialize<Person>(options),
                    _ => doc.Deserialize<Object>(options),
                };
            }
            else
            {
                throw new JsonException("JSON Object didn't have type property");
            }
        }
        throw new JsonException("Could not be parsed as a JsonDocument");
    }

    public override void Write(Utf8JsonWriter writer, ObjectOrLink? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
