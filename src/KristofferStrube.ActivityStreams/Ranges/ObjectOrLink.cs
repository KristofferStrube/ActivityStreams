using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(Object), "Object")]
[JsonDerivedType(typeof(Link), "Link")]
[JsonDerivedType(typeof(Document), "Document")]
[JsonDerivedType(typeof(Image), "Image")]
public interface ObjectOrLink
{
}
