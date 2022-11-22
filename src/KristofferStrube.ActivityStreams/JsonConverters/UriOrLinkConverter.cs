using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class UriOrLinkConverter : JsonConverter<UriOrLink?>
{
    public override UriOrLink? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        if (value is null) return null;
        if (value.StartsWith("{"))
        {
            return Deserialize<Link>(value)!;
        }
        return (UriOrLink)new Uri(value);
    }

    public override void Write(Utf8JsonWriter writer, UriOrLink? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
