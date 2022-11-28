using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Source
{
    /// <summary>
    /// The content or textual representation of the Object encoded as a JSON string. By default, the value of content is HTML. The mediaType property can be used in the object to indicate a different content type.
    /// The content may be expressed using multiple language-tagged values.
    /// </summary>
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    [JsonPropertyName("content")]
    public IEnumerable<string> Content { get; set; }

    /// <summary>
    /// The content or textual representation of the Object encoded as a JSON string. By default, the value of content is HTML. The mediaType property can be used in the object to indicate a different content type.
    /// The content may be expressed using multiple language-tagged values.
    /// </summary>
    [JsonConverter(typeof(OneOrMultipleConverter<IDictionary<string, string>>))]
    [JsonPropertyName("contentMap")]
    public IEnumerable<IDictionary<string, string>> ContentMap { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    [JsonPropertyName("mediaType")]
    public string MediaType { get; set; }
}