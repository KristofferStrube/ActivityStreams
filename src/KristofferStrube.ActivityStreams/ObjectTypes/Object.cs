using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Describes an object of any kind. The Object type serves as the base type for most of the other kinds of objects defined in the Activity Vocabulary, including other Core types such as Activity, IntransitiveActivity, Collection and OrderedCollection.
/// </summary>
public class Object : ObjectOrLink, IObject
{
    public Object() => Type = new List<string>() { "Object" };

    /// <summary>
    /// Identifies a resource attached or related to an object that potentially requires special handling. The intent is to provide a model that is at least semantically similar to attachments in email.
    /// </summary>
    [JsonPropertyName("attachment")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Attachment { get; set; }

    /// <summary>
    /// Identifies one or more entities to which this object is attributed. The attributed entities might not be Actors. For instance, an object might be attributed to the completion of another activity.
    /// </summary>
    [JsonPropertyName("attributedTo")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? AttributedTo { get; set; }

    /// <summary>
    /// Identifies one or more entities that represent the total population of entities for which the object can considered to be relevant.
    /// </summary>
    [JsonPropertyName("audience")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Audience { get; set; }

    /// <summary>
    /// Identifies one or more Objects that are part of the private secondary audience of this Object.
    /// </summary>
    [JsonPropertyName("bcc")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Bcc { get; set; }

    /// <summary>
    /// Identifies an Object that is part of the private primary audience of this Object.
    /// </summary>
    [JsonPropertyName("bto")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Bto { get; set; }

    /// <summary>
    /// Identifies an Object that is part of the public secondary audience of this Object.
    /// </summary>
    [JsonPropertyName("cc")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Cc { get; set; }

    /// <summary>
    /// Identifies the context within which the object exists or an activity was performed.
    /// The notion of "context" used is intentionally vague.The intended function is to serve as a means of grouping objects and activities that share a common originating context or purpose.An example could be all activities relating to a common project or event.
    /// </summary>
    [JsonPropertyName("context")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Context { get; set; }

    /// <summary>
    /// Identifies the entity (e.g. an application) that generated the object.
    /// </summary>
    [JsonPropertyName("generator")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Generator { get; set; }

    /// <summary>
    /// Indicates an entity that describes an icon for this object. The image should have an aspect ratio of one (horizontal) to one (vertical) and should be suitable for presentation at a small size.
    /// </summary>
    [JsonPropertyName("icon")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IImageOrLink>))]
    public IEnumerable<IImageOrLink>? Icon { get; set; }

    /// <summary>
    /// Indicates an entity that describes an image for this object. Unlike the icon property, there are no aspect ratio or display size limitations assumed.
    /// </summary>
    [JsonPropertyName("image")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IImageOrLink>))]
    public IEnumerable<IImageOrLink>? Image { get; set; }

    /// <summary>
    /// Indicates one or more entities for which this object is considered a response.
    /// </summary>
    [JsonPropertyName("inReplyTo")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? InReplyTo { get; set; }

    /// <summary>
    /// Indicates one or more physical or logical locations associated with the object.
    /// </summary>
    [JsonPropertyName("location")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Location { get; set; }

    /// <summary>
    /// Identifies a Collection containing objects considered to be responses to this object.
    /// </summary>
    [JsonPropertyName("replies")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Collection? Replies { get; set; }

    /// <summary>
    /// One or more "tags" that have been associated with an objects. A tag can be any kind of Object. The key difference between attachment and tag is that the former implies association by inclusion, while the latter implies associated by reference.
    /// </summary>
    [JsonPropertyName("tag")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Tag { get; set; }

    /// <summary>
    /// Identifies an entity considered to be part of the public primary audience of an Object.
    /// </summary>
    [JsonPropertyName("to")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? To { get; set; }

    /// <summary>
    /// Identifies one or more links to representations of the object.
    /// </summary>
    [JsonPropertyName("url")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<ILink>))]
    public IEnumerable<ILink>? Url { get; set; }

    /// <summary>
    /// The content or textual representation of the Object encoded as a JSON string. By default, the value of content is HTML. The mediaType property can be used in the object to indicate a different content type.
    /// The content may be expressed using multiple language-tagged values.
    /// </summary>
    [JsonPropertyName("content")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    public IEnumerable<string>? Content { get; set; }

    /// <summary>
    /// The content or textual representation of the Object encoded as a JSON string. By default, the value of content is HTML. The mediaType property can be used in the object to indicate a different content type.
    /// The content may be expressed using multiple language-tagged values.
    /// </summary>
    [JsonPropertyName("contentMap")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IDictionary<string, string>>))]
    public IEnumerable<IDictionary<string, string>>? ContentMap { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    [JsonPropertyName("nameMap")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IDictionary<string, string>>))]
    public IEnumerable<IDictionary<string, string>>? NameMap { get; set; }

    /// <summary>
    /// When the object describes a time-bound resource, such as an audio or video, a meeting, etc, the duration property indicates the object's approximate duration. The value must be expressed as an xsd:duration as defined by [ xmlschema11-2], section 3.3.6 (e.g. a period of 5 seconds is represented as "PT5S").
    /// </summary>
    /// <remarks>We should use the XmlConvert.ToTimeSpan method.</remarks>
    [JsonPropertyName("duration")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(XMLTimeSpanConverter))]
    public TimeSpan? Duration { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    [JsonPropertyName("endTime")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// The date and time at which the object was published.
    /// </summary>
    [JsonPropertyName("published")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public DateTime? Published { get; set; }

    /// <summary>
    /// The date and time describing the actual or expected starting time of the object. When used with an Activity object, for instance, the startTime property specifies the moment the activity began or is scheduled to begin.
    /// </summary>
    [JsonPropertyName("startTime")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// A natural language summarization of the object encoded as HTML. Multiple language tagged summaries may be provided.
    /// </summary>
    [JsonPropertyName("summary")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    public IEnumerable<string>? Summary { get; set; }

    /// <summary>
    /// A natural language summarization of the object encoded as HTML. Multiple language tagged summaries may be provided.
    /// </summary>
    [JsonPropertyName("summaryMap")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IDictionary<string, string>>))]
    public IEnumerable<IDictionary<string, string>>? SummaryMap { get; set; }

    /// <summary>
    /// 	The date and time at which the object was updated.
    /// </summary>
    [JsonPropertyName("updated")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public DateTime? Updated { get; set; }

    /// <summary>
    /// In addition to all the properties defined by the [Activity-Vocabulary], ActivityPub extends the Object by supplying the source property. The source property is intended to convey some sort of source from which the content markup was derived, as a form of provenance, or to support future editing by clients. In general, clients do the conversion from source to content, not the other way around.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("source")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Source? Source { get; set; }

    /// <summary>
    /// This is a list of all Like activities with this object as the object property, added as a side effect. The likes collection MUST be either an OrderedCollection or a Collection and MAY be filtered on privileges of an authenticated user or as appropriate when no authentication is given.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("likes")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Collection? Likes { get; set; }

    /// <summary>
    /// This is a list of all Announce activities with this object as the object property, added as a side effect. The shares collection MUST be either an OrderedCollection or a Collection and MAY be filtered on privileges of an authenticated user or as appropriate when no authentication is given.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("shares")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Collection? Shares { get; set; }

    /// <summary>
    /// Additional Data that can be added dynamically to the object.
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? ExtensionData { get; set; }
}
