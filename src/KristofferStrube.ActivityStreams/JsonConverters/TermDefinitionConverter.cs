using KristofferStrube.ActivityStreams.JsonLD;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.JsonConverters;

internal class TermDefinitionConverter : JsonConverter<ITermDefinition?>
{
    public override ITermDefinition? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out JsonDocument? doc))
        {
            if (doc.RootElement.ValueKind is JsonValueKind.String)
            {
                return new ReferenceTermDefinition(doc.Deserialize<Uri>(options)!);
            }
            else if (doc.RootElement.ValueKind is JsonValueKind.Object)
            {
                return doc.Deserialize<ExpandedTermDefinition>(options);
            }
            throw new JsonException("JSON element was neither an object nor a string.");
        }
        throw new JsonException("Could not be parsed as a JsonDocument.");
    }

    public override void Write(Utf8JsonWriter writer, ITermDefinition? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
