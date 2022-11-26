using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(ImageOrLinkConverter))]
public interface IImageOrLink : IObjectOrLink
{

}
