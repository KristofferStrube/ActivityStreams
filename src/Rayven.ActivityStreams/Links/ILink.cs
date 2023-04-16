using Rayven.ActivityStreams.JsonConverters;
using Rayven.ActivityStreams.Ranges;
using System.Text.Json.Serialization;

namespace Rayven.ActivityStreams.Links;

[JsonConverter(typeof(LinkConverter))]
public interface ILink : IImageOrLink, ICollectionPageOrLink, IEndpointsOrLink
{
    Uri? Href { get; set; }
    string? Hreflang { get; set; }
    IEnumerable<string>? Rel { get; set; }
    uint? Height { get; set; }
    uint? Width { get; set; }
}