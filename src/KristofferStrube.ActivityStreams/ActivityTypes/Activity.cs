using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Activity : Object
{
    public Activity() => Type = new List<string>() { "Activity" };

    /// <summary>
    /// Describes one or more entities that either performed or are expected to perform the activity. Any single activity can have multiple actors. The actor may be specified using an indirect Link.
    /// </summary>
    [JsonPropertyName("actor")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Actor { get; set; }

    /// <summary>
    /// Describes the direct object of the activity. For instance, in the activity "John added a movie to his wishlist", the object of the activity is the movie added.
    /// </summary>
    [JsonPropertyName("object")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Object { get; set; }

    /// <summary>
    /// Describes the indirect object, or target, of the activity. The precise meaning of the target is largely dependent on the type of action being described but will often be the object of the English preposition "to". For instance, in the activity "John added a movie to his wishlist", the target of the activity is John's wishlist. An activity can have more than one target.
    /// </summary>
    [JsonPropertyName("target")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Target { get; set; }

    /// <summary>
    /// Describes the result of the activity. For instance, if a particular action results in the creation of a new resource, the result property can be used to describe that new resource.
    /// </summary>
    [JsonPropertyName("result")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Result { get; set; }

    /// <summary>
    /// Describes an indirect object of the activity from which the activity is directed. The precise meaning of the origin is the object of the English preposition "from". For instance, in the activity "John moved an item to List B from List A", the origin of the activity is "List A".
    /// </summary>
    [JsonPropertyName("origin")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Origin { get; set; }

    /// <summary>
    /// Identifies one or more objects used (or to be used) in the completion of an Activity.
    /// </summary>
    [JsonPropertyName("instrument")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Instrument { get; set; }
}
