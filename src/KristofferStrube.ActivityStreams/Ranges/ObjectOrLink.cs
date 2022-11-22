using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class ObjectOrLink : IObjectOrLink
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

    /// <summary>
    /// Provides the globally unique identifier for an Object or Link.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
