using KristofferStrube.ActivityStreams.JsonConverters;
using KristofferStrube.ActivityStreams.JsonLD;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents something that is either an <see cref="Object"/> or a <see cref="Link"/>.
/// </summary>
[JsonConverter(typeof(ObjectOrLinkConverter))]
public interface IObjectOrLink
{
    /// <summary>
    /// The context of the JSON-LD object.
    /// </summary>
    IEnumerable<ITermDefinition>? JsonLDContext { get; set; }

    /// <summary>
    /// Provides the globally unique identifier for an Object or Link.
    /// </summary>
    string? Id { get; set; }

    /// <summary>
    /// Provides globally unique types for an Object.
    /// </summary>
    IEnumerable<string>? Type { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    string? MediaType { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    IEnumerable<string>? Name { get; set; }

    /// <summary>
    /// Identifies an entity that provides a preview of this object.
    /// </summary>
    IEnumerable<IObjectOrLink>? Preview { get; set; }
}
