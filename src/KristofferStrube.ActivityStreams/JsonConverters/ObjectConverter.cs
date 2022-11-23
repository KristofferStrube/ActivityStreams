using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class ObjectConverter : JsonConverter<IObject?>
{
    public override IObject? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out var doc))
        {
            if (doc.RootElement.TryGetProperty("type", out var type))
            {
                return type.GetString() switch {
                    // Objects
                    "Object" => doc.Deserialize<Object>(options),
                    "Collection" => doc.Deserialize<Collection>(options),
                    "OrderedCollection" => doc.Deserialize<OrderedCollection>(options),
                    "Document" => doc.Deserialize<Document>(options),
                    "Image" => doc.Deserialize<Image>(options),
                    "Video" => doc.Deserialize<Video>(options),
                    "Note" => doc.Deserialize<Note>(options),
                    "Place" => doc.Deserialize<Place>(options),
                    // Actors
                    "Application" => doc.Deserialize<Application>(options),
                    "Organísation" => doc.Deserialize<Organisation>(options),
                    "Person" => doc.Deserialize<Person>(options),
                    // Activities
                    "Activity" => doc.Deserialize<Activity>(options),
                    "Offer" => doc.Deserialize<Offer>(options),
                    "Like" => doc.Deserialize<Like>(options),
                    var value => DeserializeGenericType(doc, value, options),
                };
            }
            else
            {
                throw new JsonException("JSON Object did not have a type property.");
            }
        }
        throw new JsonException("Could not be parsed as a JsonDocument.");
    }

    private IObject DeserializeGenericType(JsonDocument doc, string type, JsonSerializerOptions options)
    {
        IObject obj = doc.Deserialize<Object>(options)!;
        obj.Type = type;
        return obj;
    }

    public override void Write(Utf8JsonWriter writer, IObject? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
