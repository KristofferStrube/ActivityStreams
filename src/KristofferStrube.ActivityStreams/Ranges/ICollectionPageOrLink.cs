using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(CollectionPageOrLinkConverter))]
public interface ICollectionPageOrLink : IObjectOrLink
{

}
