﻿using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// An abstract definition of an <see cref="Object"/>.
/// Describes an object of any kind.
/// The <see cref="IObject"/> type serves as the base type for most of the other kinds of objects defined in the Activity Vocabulary, including other Core types such as <see cref="Activity"/>, <see cref="IntransitiveActivity"/>, <see cref="Collection"/>, and <see cref="OrderedCollection"/>.
/// </summary>
[JsonConverter(typeof(ObjectConverter))]
public interface IObject : IObjectOrLink
{
    /// <summary>
    /// Identifies a resource attached or related to an object that potentially requires special handling. The intent is to provide a model that is at least semantically similar to attachments in email.
    /// </summary>
    IEnumerable<IObjectOrLink>? Attachment { get; set; }

    /// <summary>
    /// Identifies one or more entities to which this object is attributed. The attributed entities might not be Actors. For instance, an object might be attributed to the completion of another activity.
    /// </summary>
    IEnumerable<IObjectOrLink>? AttributedTo { get; set; }

    /// <summary>
    /// Identifies one or more entities that represent the total population of entities for which the object can considered to be relevant.
    /// </summary>
    IEnumerable<IObjectOrLink>? Audience { get; set; }

    /// <summary>
    /// Identifies one or more Objects that are part of the private secondary audience of this Object.
    /// </summary>
    IEnumerable<IObjectOrLink>? Bcc { get; set; }

    /// <summary>
    /// Identifies an Object that is part of the private primary audience of this Object.
    /// </summary>
    IEnumerable<IObjectOrLink>? Bto { get; set; }

    /// <summary>
    /// Identifies an Object that is part of the public secondary audience of this Object.
    /// </summary>
    IEnumerable<IObjectOrLink>? Cc { get; set; }

    /// <summary>
    /// Identifies the context within which the object exists or an activity was performed.
    /// The notion of "context" used is intentionally vague.The intended function is to serve as a means of grouping objects and activities that share a common originating context or purpose.An example could be all activities relating to a common project or event.
    /// </summary>
    IEnumerable<IObjectOrLink>? Context { get; set; }

    /// <summary>
    /// Identifies the entity (e.g. an application) that generated the object.
    /// </summary>
    IEnumerable<IObjectOrLink>? Generator { get; set; }

    /// <summary>
    /// Indicates an entity that describes an icon for this object. The image should have an aspect ratio of one (horizontal) to one (vertical) and should be suitable for presentation at a small size.
    /// </summary>
    IEnumerable<IImageOrLink>? Icon { get; set; }

    /// <summary>
    /// Indicates an entity that describes an image for this object. Unlike the icon property, there are no aspect ratio or display size limitations assumed.
    /// </summary>
    IEnumerable<IImageOrLink>? Image { get; set; }

    /// <summary>
    /// Indicates one or more entities for which this object is considered a response.
    /// </summary>
    IEnumerable<IObjectOrLink>? InReplyTo { get; set; }

    /// <summary>
    /// Indicates one or more physical or logical locations associated with the object.
    /// </summary>
    IEnumerable<IObjectOrLink>? Location { get; set; }

    /// <summary>
    /// Identifies a Collection containing objects considered to be responses to this object.
    /// </summary>
    Collection? Replies { get; set; }

    /// <summary>
    /// One or more "tags" that have been associated with an objects. A tag can be any kind of Object. The key difference between attachment and tag is that the former implies association by inclusion, while the latter implies associated by reference.
    /// </summary>
    IEnumerable<IObjectOrLink>? Tag { get; set; }

    /// <summary>
    /// Identifies an entity considered to be part of the public primary audience of an Object.
    /// </summary>
    IEnumerable<IObjectOrLink>? To { get; set; }

    /// <summary>
    /// Identifies one or more links to representations of the object.
    /// </summary>
    IEnumerable<ILink>? Url { get; set; }

    /// <summary>
    /// The content or textual representation of the Object encoded as a JSON string. By default, the value of content is HTML. The mediaType property can be used in the object to indicate a different content type.
    /// The content may be expressed using multiple language-tagged values.
    /// </summary>
    IEnumerable<string>? Content { get; set; }

    /// <summary>
    /// The content or textual representation of the Object encoded as a JSON string. By default, the value of content is HTML. The mediaType property can be used in the object to indicate a different content type.
    /// The content may be expressed using multiple language-tagged values.
    /// </summary>
    IEnumerable<IDictionary<string, string>>? ContentMap { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    IEnumerable<IDictionary<string, string>>? NameMap { get; set; }

    /// <summary>
    /// When the object describes a time-bound resource, such as an audio or video, a meeting, etc, the duration property indicates the object's approximate duration. The value must be expressed as an xsd:duration as defined by [ xmlschema11-2], section 3.3.6 (e.g. a period of 5 seconds is represented as "PT5S").
    /// </summary>
    TimeSpan? Duration { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    DateTime? EndTime { get; set; }

    /// <summary>
    /// The date and time at which the object was published.
    /// </summary>
    DateTime? Published { get; set; }

    /// <summary>
    /// The date and time describing the actual or expected starting time of the object. When used with an Activity object, for instance, the startTime property specifies the moment the activity began or is scheduled to begin.
    /// </summary>
    DateTime? StartTime { get; set; }

    /// <summary>
    /// A natural language summarization of the object encoded as HTML. Multiple language tagged summaries may be provided.
    /// </summary>
    IEnumerable<string>? Summary { get; set; }

    /// <summary>
    /// A natural language summarization of the object encoded as HTML. Multiple language tagged summaries may be provided.
    /// </summary>
    IEnumerable<IDictionary<string, string>>? SummaryMap { get; set; }

    /// <summary>
    /// The date and time at which the object was updated.
    /// </summary>
    DateTime? Updated { get; set; }

    /// <summary>
    /// In addition to all the properties defined by the [Activity-Vocabulary], ActivityPub extends the Object by supplying the source property. The source property is intended to convey some sort of source from which the content markup was derived, as a form of provenance, or to support future editing by clients. In general, clients do the conversion from source to content, not the other way around.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    Source? Source { get; set; }

    /// <summary>
    /// Any additional properties that were not mapped to existing properties when this object was deserialized.
    /// </summary>
    public Dictionary<string, JsonElement>? ExtensionData { get; set; }
}
