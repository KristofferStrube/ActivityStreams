using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(LinkConverter))]
public class Link : ObjectOrLink, IImageOrLink
{
    [JsonPropertyName("href")]
    public Uri? Href { get; set; }
}
