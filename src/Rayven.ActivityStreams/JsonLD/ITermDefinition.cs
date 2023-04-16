using Rayven.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace Rayven.ActivityStreams.JsonLD;

[JsonConverter(typeof(TermDefinitionConverter))]
public interface ITermDefinition
{
}
