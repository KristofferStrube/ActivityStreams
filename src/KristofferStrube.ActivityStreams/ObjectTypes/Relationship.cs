using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Describes a relationship between two individuals.
/// The subject and object properties are used to identify the connected individuals.
/// The <see cref="Relationship"/> object is used to represent relationships between individuals.
/// It can be used, for instance, to describe that one person is a friend of another, or that one person is a member of a particular organization.
/// The intent of modeling Relationship in this way is to allow descriptions of activities that operate on the relationships in general, and to allow representation of Collections of relationships.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-relationship">See the API definition here</see>.</remarks>
public class Relationship : Object
{
    /// <summary>
    /// Constructs a new <see cref="Relationship"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Relationship()
    {
        Type = new List<string>() { "Relationship" };
    }

    /// <summary>
    /// The subject property identifies one of the connected individuals. For instance, for a Relationship object describing "John is related to Sally", subject would refer to John.
    /// </summary>
    [JsonPropertyName("subject")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public IObjectOrLink? Subject { get; set; }

    /// <summary>
    /// Describes the entity to which the subject is related.
    /// </summary>
    [JsonPropertyName("object")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Object { get; set; }

    /// <summary>
    /// The relationship property identifies the kind of relationship that exists between subject and object.
    /// </summary>
    /// <remarks>This is called <c>RelationshipAttribute</c> because we can't have attributes that are called the same as the class.</remarks>
    [JsonPropertyName("relationship")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? RelationshipAttribute { get; set; }
}
