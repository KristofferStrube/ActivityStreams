using KristofferStrube.ActivityStreams.JsonConverters;
using KristofferStrube.ActivityStreams.JsonLD;
using System.Dynamic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(ObjectOrLinkConverter))]
public interface IObjectOrLink
{
    dynamic? Body { get; set; }
    string? Id { get; set; }
    IEnumerable<ITermDefinition>? JsonLDContext { get; set; }
    IEnumerable<string>? Type { get; set; }
    string? MediaType { get; set; }
    IEnumerable<string>? Name { get; set; }
    IEnumerable<IObjectOrLink>? Preview { get; set; }
}
