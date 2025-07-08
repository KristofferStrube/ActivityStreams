using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// An <see cref="Activity"/> is a subtype of <see cref="Object"/> that describes some form of action that may happen, is currently happening, or has already happened.
/// The <see cref="Activity"/> type itself serves as an abstract base type for all types of activities.
/// It is important to note that the <see cref="Activity"/> type itself does not carry any specific semantics about the kind of action being taken.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-activity">See the API definition here</see>.</remarks>
public class Activity : Object
{
    /// <summary>
    /// Constructs a new <see cref="Activity"/> and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Activity()
    {
        Type = new List<string>() { "Activity" };
    }

    /// <summary>
    /// Describes one or more entities that either performed or are expected to perform the activity.
    /// Any single activity can have multiple actors.
    /// The actor may be specified using an indirect <see cref="ILink"/>.
    /// </summary>
    [JsonPropertyName("actor")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Actor { get; set; }

    /// <summary>
    /// Describes the direct object of the <see cref="Activity"/>.
    /// For instance, in the activity "John added a movie to his wishlist", the object of the activity is the movie added.
    /// </summary>
    [JsonPropertyName("object")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Object { get; set; }

    /// <summary>
    /// Describes the indirect object, or target, of the activity.
    /// The precise meaning of the target is largely dependent on the type of action being described but will often be the object of the English preposition "to".
    /// For instance, in the activity "John added a movie to his wishlist", the target of the activity is John's wishlist.
    /// An activity can have more than one target.
    /// </summary>
    [JsonPropertyName("target")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Target { get; set; }

    /// <summary>
    /// Describes the result of the activity.
    /// For instance, if a particular action results in the creation of a new resource, the result property can be used to describe that new resource.
    /// </summary>
    [JsonPropertyName("result")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Result { get; set; }

    /// <summary>
    /// Describes an indirect object of the activity from which the activity is directed.
    /// The precise meaning of the origin is the object of the English preposition "from".
    /// For instance, in the activity "John moved an item to List B from List A", the origin of the activity is "List A".
    /// </summary>
    [JsonPropertyName("origin")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Origin { get; set; }

    /// <summary>
    /// Identifies one or more objects used (or to be used) in the completion of an <see cref="Activity"/>.
    /// </summary>
    [JsonPropertyName("instrument")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Instrument { get; set; }
}
