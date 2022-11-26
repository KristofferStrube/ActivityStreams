using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams.JsonLD;

[JsonConverter(typeof(TermDefinitionConverter))]
public interface ITermDefinition
{
}
