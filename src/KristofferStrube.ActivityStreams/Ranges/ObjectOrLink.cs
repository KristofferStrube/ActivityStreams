using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(Object), "Object")]
[JsonDerivedType(typeof(Link), "Link")]
[JsonDerivedType(typeof(Document), "Document")]
[JsonDerivedType(typeof(Image), "Image")]
public class ObjectOrLink
{
    /// <summary>
    /// The context of the JSON-LD object.
    /// </summary>
    [JsonPropertyName("@context")]
    public Uri? JsonLDContext { get; set; }

    /// <summary>
    /// Provides the globally unique identifier for an Object or Link.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Provides the globally unique identifier for an Object or Link.
    /// </summary>
    [JsonIgnore]
    public Uri? IdAsUri => Id is null || JsonLDContext is null ? null : Uri.TryCreate(Id, new UriCreationOptions(), out var uri) ? uri : new Uri($"{JsonLDContext.AbsoluteUri}/{Id}");
}
