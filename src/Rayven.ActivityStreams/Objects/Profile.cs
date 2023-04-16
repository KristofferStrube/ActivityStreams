using System.Text.Json.Serialization;

namespace Rayven.ActivityStreams.Objects;

public class Profile : Object
{
    /// <summary>
    /// On a Profile object, the describes property identifies the object described by the Profile.
    /// </summary>
    [JsonPropertyName("describes")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public IObject? Describes { get; set; }
}
