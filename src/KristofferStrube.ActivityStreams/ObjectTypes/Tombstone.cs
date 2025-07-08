using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// A <see cref="Tombstone"/> represents a content object that has been deleted.
/// It can be used in <see cref="Collection"/>s to signify that there used to be an object at this position, but it has been deleted.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-tombstone">See the API definition here</see>.</remarks>
public class Tombstone : Object
{
    /// <summary>
    /// Constructs a new <see cref="Tombstone"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Tombstone()
    {
        Type = new List<string>() { "Tombstone" };
    }

    /// <summary>
    /// On a Tombstone object, the formerType property identifies the type of the object that was deleted.
    /// </summary>
    [JsonPropertyName("formerType")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    public IEnumerable<string>? FormerType { get; set; }

    /// <summary>
    /// On a Tombstone object, the deleted property is a timestamp for when the object was deleted.
    /// </summary>
    [JsonPropertyName("deleted")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public DateTime? Deleted { get; set; }
}
