using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Profile : Object
{
    public Profile() => Type = new List<string>() { "Profile" };

    /// <summary>
    /// On a Profile object, the describes property identifies the object described by the Profile.
    /// </summary>
    [JsonPropertyName("describes")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public IObject? Describes { get; set; }
}
