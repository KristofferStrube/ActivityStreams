using Rayven.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace Rayven.ActivityStreams.Ranges;

[JsonConverter(typeof(CollectionOrLinkConverter))]
public interface ICollectionOrLink : IObjectOrLink
{

}
