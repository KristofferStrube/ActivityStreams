using Rayven.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace Rayven.ActivityStreams.Ranges;

[JsonConverter(typeof(CollectionPageOrLinkConverter))]
public interface ICollectionPageOrLink : ICollectionOrLink
{

}
