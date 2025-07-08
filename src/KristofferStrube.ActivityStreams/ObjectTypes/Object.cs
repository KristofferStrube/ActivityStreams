using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Describes an object of any kind. The Object type serves as the base type for most of the other kinds of objects defined in the Activity Vocabulary, including other Core types such as Activity, IntransitiveActivity, Collection and OrderedCollection.
/// </summary>
public class Object : ObjectOrLink, IObject
{
    /// <summary>
    /// Constructs a new <see cref="Object"/> and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Object()
    {
        Type = new List<string>() { "Object" };
    }

    /// <inheritdoc/>
    [JsonPropertyName("attachment")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Attachment { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("attributedTo")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? AttributedTo { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("audience")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Audience { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("bcc")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Bcc { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("bto")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Bto { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("cc")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Cc { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("context")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Context { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("generator")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Generator { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("icon")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IImageOrLink>))]
    public IEnumerable<IImageOrLink>? Icon { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("image")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IImageOrLink>))]
    public IEnumerable<IImageOrLink>? Image { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("inReplyTo")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? InReplyTo { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("location")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Location { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("replies")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Collection? Replies { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("tag")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Tag { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("to")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? To { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("url")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<ILink>))]
    public IEnumerable<ILink>? Url { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("content")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    public IEnumerable<string>? Content { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("contentMap")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IDictionary<string, string>>))]
    public IEnumerable<IDictionary<string, string>>? ContentMap { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("nameMap")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IDictionary<string, string>>))]
    public IEnumerable<IDictionary<string, string>>? NameMap { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("duration")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(XMLTimeSpanConverter))]
    public TimeSpan? Duration { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("endTime")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public DateTime? EndTime { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("published")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public DateTime? Published { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("startTime")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public DateTime? StartTime { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("summary")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    public IEnumerable<string>? Summary { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("summaryMap")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IDictionary<string, string>>))]
    public IEnumerable<IDictionary<string, string>>? SummaryMap { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("updated")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public DateTime? Updated { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("source")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Source? Source { get; set; }

    /// <summary>
    /// This is a list of all Like activities with this object as the object property, added as a side effect. The likes collection must be either an OrderedCollection or a Collection and may be filtered on privileges of an authenticated user or as appropriate when no authentication is given.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("likes")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Collection? Likes { get; set; }

    /// <summary>
    /// This is a list of all Announce activities with this object as the object property, added as a side effect. The shares collection must be either an OrderedCollection or a Collection and may be filtered on privileges of an authenticated user or as appropriate when no authentication is given.
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
