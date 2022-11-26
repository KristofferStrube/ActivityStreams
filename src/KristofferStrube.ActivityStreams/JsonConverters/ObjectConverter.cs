using KristofferStrube.ActivityStreams;
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
                string? matchingType;
                IEnumerable<string> allTypes = new List<string>();
                if (type.ValueKind == JsonValueKind.Array)
                {
                    allTypes = type.EnumerateArray().Select(t => t.GetString()!);
                    matchingType = allTypes.FirstOrDefault(t => ObjectTypes.Types.ContainsKey(t!), null);
                }
                else
                {
                    matchingType = type.GetString();
                    allTypes = new List<string>() { matchingType! };
                }
                IObject? obj;
                if (matchingType is null)
                {
                    return null;
                }
                else if (ObjectTypes.Types.ContainsKey(matchingType))
                {
                    obj = (IObject?)doc.Deserialize(ObjectTypes.Types[matchingType], options);
                }
                else
                {
                    obj = doc.Deserialize<Object?>(options);
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
