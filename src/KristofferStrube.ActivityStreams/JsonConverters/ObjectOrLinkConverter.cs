using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class ObjectOrLinkConverter : JsonConverter<IObjectOrLink?>
{
    public override IObjectOrLink? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out var doc))
        {
            if (doc.RootElement.ValueKind == JsonValueKind.String)
            {
                return doc.Deserialize<ILink>(options);
            }
            else if (doc.RootElement.TryGetProperty("type", out var type))
            {
                return type.GetString() switch {
                    "Link" => doc.Deserialize<ILink>(options),
                    _ => doc.Deserialize<IObject>(options),
                };
            }
            else
            {
                return doc.Deserialize<ObjectOrLink>(options);
            }
        }
        throw new JsonException("Could not be parsed as a JsonDocument.");
    }

    public override void Write(Utf8JsonWriter writer, IObjectOrLink? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
