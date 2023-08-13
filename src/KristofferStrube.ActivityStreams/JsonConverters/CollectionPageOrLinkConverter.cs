﻿using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

public class CollectionPageOrLinkConverter : JsonConverter<ICollectionPageOrLink?>
{
    public override ICollectionPageOrLink? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out JsonDocument? doc))
        {
            if (doc.RootElement.ValueKind is JsonValueKind.String)
            {
                return doc.Deserialize<ILink>(options);
            }
            else if (doc.RootElement.TryGetProperty("type", out JsonElement type))
            {
                return type.GetString() switch
                {
                    "Link" => doc.Deserialize<ILink>(options),
                    "CollectionPage" => (CollectionPage?)doc.Deserialize<IObject>(options),
                    _ => throw new JsonException("JSON element was not an CollectionPage or a Link."),
                };
            }
            throw new JsonException("JSON element did not have a type property nor was it a string.");
        }
        throw new JsonException("Could not be parsed as a JsonDocument.");
    }

    public override void Write(Utf8JsonWriter writer, ICollectionPageOrLink? value, JsonSerializerOptions options)
    {
        if (value is null)
        {
            return;
        }
        else if (value is ILink)
        {
            writer.WriteRawValue(Serialize(value, typeof(ILink), options));
        }
        else if (value is CollectionPage)
        {
            writer.WriteRawValue(Serialize(value, typeof(CollectionPage), options));
        }
        else
        {
            writer.WriteRawValue(Serialize(value, typeof(ObjectOrLink), options));
        }
    }
}
