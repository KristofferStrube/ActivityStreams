using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(CollectionOrLinkConverter))]
public interface ICollectionOrLink : IObjectOrLink
{

}
