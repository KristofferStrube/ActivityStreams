using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Profile : Object
{
    /// <summary>
    /// On a Profile object, the describes property identifies the object described by the Profile.
    /// </summary>
    [JsonPropertyName("describes")]
    public IObject? Describes { get; set; }
}
