using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class ObjectConverter : JsonConverter<IObject?>
{
    public override IObject? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out JsonDocument? doc))
        {
            if (doc.RootElement.TryGetProperty("type", out JsonElement type))
            {
                string? matchingType;
                if (type.ValueKind is JsonValueKind.Array)
                {
                    matchingType = type.EnumerateArray().Select(t => t.GetString()!).FirstOrDefault(t => ObjectTypes.Types.ContainsKey(t!), null);
                }
                else
                {
                    matchingType = type.GetString();
                }
                IObject? result = null;
                if (matchingType is not null && ObjectTypes.Types.TryGetValue(matchingType!, out Type? value))
                {
                    result = (IObject?)doc.Deserialize(value, options);
                }
                else if (matchingType is not null)
                {
                    result = doc.Deserialize<Object?>(options);
                }
                if (result is not null)
                {
                    return result;
                }
                return null;
            }
            else
            {
                throw new JsonException("JSON Object did not have a type property.");
            }
        }
        throw new JsonException("Could not be parsed as a JsonDocument.");
    }

    public override void Write(Utf8JsonWriter writer, IObject? value, JsonSerializerOptions options)
    {
        if (value is null)
        {
            return;
        }

        string? matchingType = ObjectTypes.Types.Keys.FirstOrDefault(k => value.GetType().IsEquivalentTo(ObjectTypes.Types[k!]), null);
        if (matchingType is null)
        {
            writer.WriteRawValue(Serialize(value, typeof(object), options));
        }
        else
        {
            if (value.Type is null)
            {
                value.Type = new List<string>() { matchingType };
            }
            else if (!value.Type.Contains(matchingType))
            {
                value.Type = value.Type.Append(matchingType);
            }
            writer.WriteRawValue(Serialize(value, ObjectTypes.Types[matchingType], options));
        }
    }
}
