using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(ObjectOrLinkConverter))]
public interface IObjectOrLink
{
    string? Id { get; set; }
    Uri? IdAsUri { get; }
    Uri? JsonLDContext { get; set; }
    string? Type { get; set; }
}
