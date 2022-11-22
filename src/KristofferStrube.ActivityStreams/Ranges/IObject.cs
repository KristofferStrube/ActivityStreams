using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(ObjectConverter))]
public interface IObject : IObjectOrLink
{
}
