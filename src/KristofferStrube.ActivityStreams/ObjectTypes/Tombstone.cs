using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Tombstone : Object
{
    public Tombstone() => Type = new List<string>() { "Tombstone" };

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
