using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(LinkConverter))]
public interface ILink : IImageOrLink
{
    Uri? Href { get; set; }
}