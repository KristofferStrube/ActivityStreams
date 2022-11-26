using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(ObjectOrLinkConverter))]
public interface IObjectOrLink
{
    string? Id { get; set; }
    Uri? JsonLDContext { get; set; }
    IEnumerable<string>? Type { get; set; }
    string? MediaType { get; set; }
    IEnumerable<string>? Name { get; set; }
    IEnumerable<IObjectOrLink>? Preview { get; set; }
}
