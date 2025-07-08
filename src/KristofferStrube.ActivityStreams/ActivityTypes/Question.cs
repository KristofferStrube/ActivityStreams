using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents a question being asked. <see cref="Question"/> objects are an extension of <see cref="IntransitiveActivity"/>.
/// That is, the <see cref="Question"/> object is an <see cref="Activity"/>, but the direct object is the question itself and therefore it would not contain an <see cref="Activity.Object"/> property.
/// Either of the <see cref="AnyOf"/> and <see cref="OneOf"/> properties may be used to express possible answers, but a <see cref="Question"/> object must not have both properties.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-question">See the API definition here</see>.</remarks>
public class Question : IntransitiveActivity
{
    /// <summary>
    /// Constructs a new <see cref="Question"/> intransitive activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Question()
    {
        Type = new List<string>() { "Question" };
    }

    /// <summary>
    /// Identifies an exclusive option for a Question. Use of oneOf implies that the Question can have only a single answer.
    /// To indicate that a Question can have multiple answers, use anyOf.
    /// </summary>
    [JsonPropertyName("oneOf")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? OneOf { get; set; }

    /// <summary>
    /// Identifies an inclusive option for a Question. Use of anyOf implies that the Question can have multiple answers.
    /// To indicate that a Question can have only one answer, use oneOf.
    /// </summary>
    [JsonPropertyName("anyOf")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? AnyOf { get; set; }

    /// <summary>
    /// Indicates that a question has been closed, and answers are no longer accepted.
    /// </summary>
    [JsonPropertyName("closed")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<DateTimeBooleanObjectOrLink>))]
    public IEnumerable<DateTimeBooleanObjectOrLink>? Closed { get; set; }
}
