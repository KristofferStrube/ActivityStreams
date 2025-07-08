using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents something that is either an <see cref="Image"/> or a <see cref="Link"/>.
/// </summary>
[JsonConverter(typeof(ImageOrLinkConverter))]
public interface IImageOrLink : IObjectOrLink
{

}
