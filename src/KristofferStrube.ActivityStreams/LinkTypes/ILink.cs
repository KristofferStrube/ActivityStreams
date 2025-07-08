using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// An abstract definition of a <see cref="Link"/>.
/// A <see cref="ILink"/> is an indirect, qualified reference to a resource identified by a URL.
/// The fundamental model for links is established by [ RFC5988].
/// Many of the properties defined by the Activity Vocabulary allow values that are either instances of <see cref="IObject"/> or <see cref="ILink"/> (<see cref="IObjectOrLink"/>).
/// When a Link is used, it establishes a qualified relation connecting the subject (the containing object) to the resource identified by the href.
/// Properties of the <see cref="ILink"/> are properties of the reference as opposed to properties of the resource.
/// </summary>
[JsonConverter(typeof(LinkConverter))]
public interface ILink : IImageOrLink, ICollectionPageOrLink, IEndpointsOrLink
{
    /// <summary>
    /// The target resource pointed to by a <see cref="Link"/>.
    /// </summary>
    Uri? Href { get; set; }

    /// <summary>
    /// A link relation associated with a <see cref="Link"/>.
    /// The value must conform to both the[HTML5] and[RFC5988] "link relation" definitions.
    /// In the[HTML5], any string not containing the "space" U+0020, "tab" (U+0009), "LF" (U+000A), "FF" (U+000C), "CR" (U+000D) or "," (U+002C) characters can be used as a valid link relation.
    /// </summary>
    IEnumerable<string>? Rel { get; set; }

    /// <summary>
    /// Hints as to the language used by the target resource.
    /// Value must be a [BCP47] Language-Tag.
    /// </summary>
    string? Hreflang { get; set; }

    /// <summary>
    /// On a <see cref="Link"/>, specifies a hint as to the rendering height in device-independent pixels of the linked resource.
    /// </summary>
    uint? Height { get; set; }

    /// <summary>
    /// On a <see cref="Link"/>, specifies a hint as to the rendering width in device-independent pixels of the linked resource.
    /// </summary>
    uint? Width { get; set; }
}