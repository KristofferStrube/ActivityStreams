using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Question : Activity
{
    public Question() => Type = new List<string>() { "Question" };

    /// <summary>
    /// Identifies an exclusive option for a Question. Use of oneOf implies that the Question can have only a single answer. To indicate that a Question can have multiple answers, use anyOf.
    /// </summary>
    [JsonPropertyName("oneOf")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? OneOf { get; set; }

    /// <summary>
    /// Identifies an inclusive option for a Question. Use of anyOf implies that the Question can have multiple answers. To indicate that a Question can have only one answer, use oneOf.
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
