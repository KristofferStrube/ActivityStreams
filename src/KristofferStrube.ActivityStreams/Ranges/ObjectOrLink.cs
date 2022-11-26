using KristofferStrube.ActivityStreams.JsonConverters;
using KristofferStrube.ActivityStreams.JsonLD;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class ObjectOrLink : IObjectOrLink
{
    /// <summary>
    /// The context of the JSON-LD object.
    /// </summary>
    [JsonPropertyName("@context")]
    [JsonConverter(typeof(OneOrMultipleConverter<ITermDefinition>))]
    public IEnumerable<ITermDefinition>? JsonLDContext { get; set; }

    /// <summary>
    /// Provides the globally unique identifier for an Object or Link.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Provides globally unique types for an Object.
    /// </summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    public IEnumerable<string>? Type { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    [JsonPropertyName("name")]
    public IEnumerable<string>? Name { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    [JsonPropertyName("mediaType")]
    public string? MediaType { get; set; }

    /// <summary>
    /// Identifies an entity that provides a preview of this object.
    /// </summary>
    [JsonPropertyName("preview")]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Preview { get; set; }
}
