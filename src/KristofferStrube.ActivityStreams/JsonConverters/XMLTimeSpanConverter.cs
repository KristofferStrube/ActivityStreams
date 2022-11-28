using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class XMLTimeSpanConverter : JsonConverter<TimeSpan?>
{
    public override TimeSpan? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();
        if (value is null)
        {
            return null;
        }

        return XmlConvert.ToTimeSpan(value);
    }

    public override void Write(Utf8JsonWriter writer, TimeSpan? value, JsonSerializerOptions options)
    {
        if (value is null) return;
        writer.WriteStringValue(XmlConvert.ToString(value.Value));
    }
}
