using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(ObjectOrLinkConverter))]
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
    public Uri? IdAsUri => Id is null || JsonLDContext is null ? null : new Uri(JsonLDContext, Id);
}
