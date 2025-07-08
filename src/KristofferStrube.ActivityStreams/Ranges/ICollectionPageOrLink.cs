using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents something that is either a <see cref="CollectionPage"/> or a <see cref="Link"/>.
/// </summary>
[JsonConverter(typeof(CollectionPageOrLinkConverter))]
public interface ICollectionPageOrLink : ICollectionOrLink
{

}
