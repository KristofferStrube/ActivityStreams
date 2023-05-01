using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Relationship : Object
{
    public Relationship() => Type = new List<string>() { "Relationship" };

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
