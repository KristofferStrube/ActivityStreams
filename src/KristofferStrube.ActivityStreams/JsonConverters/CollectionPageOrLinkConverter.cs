using System.Collections;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class CollectionPageOrLinkConverter : JsonConverter<ICollectionPageOrLink?>
{
    public override ICollectionPageOrLink? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out var doc))
        {
            if (doc.RootElement.ValueKind == JsonValueKind.String)
            {
                return doc.Deserialize<ILink>(options);
            }
            else if (doc.RootElement.TryGetProperty("type", out var type))
            {
                return type.GetString() switch
                {
                    "Link" => doc.Deserialize<ILink>(options),
                    "CollectionPage" => doc.Deserialize<CollectionPage>(options),
                    _ => throw new JsonException("JSON element was not an CollectionPage or a Link."),
                };
            }
            throw new JsonException("JSON element did not have a type property nor was it a string.");
        }
        throw new JsonException("Could not be parsed as a JsonDocument.");
    }

    public override void Write(Utf8JsonWriter writer, ICollectionPageOrLink? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
