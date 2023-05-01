using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Link : ObjectOrLink, ILink
{
    public Link() => Type = new List<string>() { "Link" };

    /// <summary>
    /// On a Link, specifies a hint as to the rendering height in device-independent pixels of the linked resource.
    /// </summary>
    [JsonPropertyName("height")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public uint? Height { get; set; }

    /// <summary>
    /// The target resource pointed to by a Link.
    /// </summary>
    [JsonPropertyName("href")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Uri? Href { get; set; }

    /// <summary>
    /// Hints as to the language used by the target resource. Value must be a [BCP47] Language-Tag.
    /// </summary>
    [JsonPropertyName("hreflang")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? Hreflang { get; set; }

    /// <summary>
    /// A link relation associated with a Link.The value must conform to both the[HTML5] and[RFC5988] "link relation" definitions.
    /// In the[HTML5], any string not containing the "space" U+0020, "tab" (U+0009), "LF" (U+000A), "FF" (U+000C), "CR" (U+000D) or "," (U+002C) characters can be used as a valid link relation.
    /// </summary>
    [JsonPropertyName("rel")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    public IEnumerable<string>? Rel { get; set; }

    /// <summary>
    /// On a Link, specifies a hint as to the rendering width in device-independent pixels of the linked resource.
    /// </summary>
    [JsonPropertyName("width")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public uint? Width { get; set; }
}
