using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

public class LinkConverter : JsonConverter<ILink?>
{
    public override ILink? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out JsonDocument? doc))
        {
            if (doc.RootElement.ValueKind is JsonValueKind.String)
            {
                return new Link { Href = doc.Deserialize<Uri>(options), Type = new List<string>() { "Link" } };
            }
            else if (doc.RootElement.TryGetProperty("type", out JsonElement type))
            {
                Link? link = type.GetString() switch
                {
                    "Link" => doc.Deserialize<Link>(options),
                    "Mention" => doc.Deserialize<Mention>(options),
                    _ => throw new JsonException("JSON element was not a Link or a Mention."),
                };
                if (link is null)
                {
                    return null;
                }
                return link;
            }
            else if (doc.Deserialize<Link?>(options) is Link link)
            {
                link.Type = new List<string>() { "Link" };
                return link;
            }
            throw new JsonException("JSON element did not have a type property nor was it a string.");
        }
        throw new JsonException("Could not be parsed as a JsonDocument.");
    }

    public override void Write(Utf8JsonWriter writer, ILink? value, JsonSerializerOptions options)
    {
        if (value is null)
        {
            return;
        }

        if (value.JsonLDContext is null
            && value.Id is null
            && value.Name is null
            && value.MediaType is null
            && value.Preview is null
            && value.Hreflang is null
            && value.Rel is null
            && value.Height is null
            && value.Width is null
            && value.Href is not null)
        {
            writer.WriteStringValue(value.Href.ToString());
        }
        else
        {
            if (value.Type is null)
            {
                value.Type = new List<string>() { "Link" };
            }
            else if (!value.Type.Contains("Link") && !value.Type.Contains("Mention"))
            {
                value.Type = value.Type.Append("Link");
            }
            writer.WriteRawValue(Serialize(value, typeof(Link), options));
        }
    }
}
