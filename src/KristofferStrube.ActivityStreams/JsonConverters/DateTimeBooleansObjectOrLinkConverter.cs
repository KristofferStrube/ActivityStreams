using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class DateTimeBooleanObjectOrLinkConverter : JsonConverter<DateTimeBooleanObjectOrLink?>
{
    public override DateTimeBooleanObjectOrLink? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out JsonDocument? doc))
        {
            if (doc.RootElement.ValueKind is JsonValueKind.True)
            {
                return new() { Value = true };
            }
            else if (doc.RootElement.ValueKind is JsonValueKind.False)
            {
                return new() { Value = false };
            }
            else if (doc.RootElement.ValueKind is JsonValueKind.Number)
            {
                return new() { Value = doc.RootElement.GetDecimal() != 0 };
            }
            else if (doc.RootElement.ValueKind is JsonValueKind.String)
            {
                if (doc.RootElement.TryGetDateTime(out DateTime datetime))
                {
                    return new() { Value = datetime };
                }
                else if ((new object[] { "true", "false", "1", "0" }).Contains(doc.Deserialize<string>(options)))
                {
                    return new() { Value = doc.Deserialize<string>(options) is "true" or "1" };
                }
                return new() { Value = doc.Deserialize<ILink>(options)! };
            }
            else if (doc.RootElement.TryGetProperty("type", out JsonElement type))
            {
                return type.GetString() switch
                {
                    "Link" => new() { Value = doc.Deserialize<ILink>(options)! },
                    _ => new() { Value = doc.Deserialize<IObject>(options)! }
                };
            }
            else
            {
                return new() { Value = doc.Deserialize<ObjectOrLink>(options)! };
            }
        }
        throw new JsonException("Could not be parsed as a JsonDocument.");
    }

    public override void Write(Utf8JsonWriter writer, DateTimeBooleanObjectOrLink? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
