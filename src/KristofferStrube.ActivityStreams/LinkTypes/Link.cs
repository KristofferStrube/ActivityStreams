using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// An abstract definition of a <see cref="Link"/>.
/// A <see cref="Link"/> is an indirect, qualified reference to a resource identified by a URL.
/// The fundamental model for links is established by [ RFC5988].
/// Many of the properties defined by the Activity Vocabulary allow values that are either instances of <see cref="Object"/> or <see cref="Link"/> (<see cref="IObjectOrLink"/>).
/// When a Link is used, it establishes a qualified relation connecting the subject (the containing object) to the resource identified by the <see cref="Href"/>.
/// Properties of the <see cref="Link"/> are properties of the reference as opposed to properties of the resource.
/// </summary>
public class Link : ObjectOrLink, ILink
{
    /// <summary>
    /// Constructs a new <see cref="Link"/> and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Link()
    {
        Type = new List<string>() { "Link" };
    }

    /// <inheritdoc/>
    [JsonPropertyName("height")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public uint? Height { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("href")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Uri? Href { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("hreflang")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? Hreflang { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("rel")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    public IEnumerable<string>? Rel { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("width")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public uint? Width { get; set; }
}
