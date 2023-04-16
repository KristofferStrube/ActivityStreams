using Rayven.ActivityStreams.JsonConverters;
using Rayven.ActivityStreams.JsonLD;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Rayven.ActivityStreams.Ranges;

[JsonConverter(typeof(ObjectOrLinkConverter))]
public interface IObjectOrLink
{
    string? Id { get; set; }
    IEnumerable<ITermDefinition>? JsonLDContext { get; set; }
    IEnumerable<string>? Type { get; set; }
    string? MediaType { get; set; }
    IEnumerable<string>? Name { get; set; }
    IEnumerable<IObjectOrLink>? Preview { get; set; }
}
