using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams.JsonLD;

/// <summary>
/// An abstract definition of a JSON-LD context.
/// </summary>
[JsonConverter(typeof(TermDefinitionConverter))]
public interface ITermDefinition
{
}
