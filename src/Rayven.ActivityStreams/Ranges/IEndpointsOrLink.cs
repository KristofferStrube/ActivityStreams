using Rayven.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace Rayven.ActivityStreams.Ranges;

[JsonConverter(typeof(EndpointsOrLinkConverter))]
public interface IEndpointsOrLink
{
}
