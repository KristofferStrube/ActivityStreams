using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Tombstone : Object
{
    /// <summary>
    /// On a Tombstone object, the formerType property identifies the type of the object that was deleted.
    /// </summary>
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    [JsonPropertyName("formerType")]
    public IEnumerable<string>? FormerType { get; set; }

    /// <summary>
    /// On a Tombstone object, the deleted property is a timestamp for when the object was deleted.
    /// </summary>
    [JsonPropertyName("deleted")]
    public DateTime? Deleted { get; set; }
}
