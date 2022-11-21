using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;


[JsonDerivedType(typeof(Uri), "URI")]
[JsonDerivedType(typeof(Link), "Link")]
public interface UriOrLink
{
}
