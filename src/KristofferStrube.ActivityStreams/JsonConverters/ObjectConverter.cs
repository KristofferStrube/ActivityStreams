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
                IEnumerable<string> allTypes = new List<string>();
                if (type.ValueKind is JsonValueKind.Array)
                {
                    allTypes = type.EnumerateArray().Select(t => t.GetString()!);
                    matchingType = allTypes.FirstOrDefault(t => ObjectTypes.Types.ContainsKey(t!), null);
                }
                else
                {
                    matchingType = type.GetString();
                    allTypes = new List<string>() { matchingType! };
                }
                IObject? obj = null;
                if (matchingType is null)
                {
                    return null;
                }
                else if (ObjectTypes.Types.TryGetValue(matchingType!, out Type? value))
                {
                    obj = (IObject?)doc.Deserialize(value, options);
                }
                else if (matchingType is not null)
                {
                    obj = doc.Deserialize<Object?>(options);
                }
                if (obj is null)
                {
                    return null;
                }

                obj.Type = allTypes;
                return obj;
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
        throw new NotImplementedException();
    }
}
