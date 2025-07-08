using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// A Profile is a content object that describes another <see cref="Object"/>, typically used to describe <see cref="Actor"/> objects.
/// The <see cref="Describes"/> property is used to reference the object being described by the profile.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-profile">See the API definition here</see>.</remarks>
public class Profile : Object
{
    /// <summary>
    /// Constructs a new <see cref="Profile"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Profile()
    {
        Type = new List<string>() { "Profile" };
    }

    /// <summary>
    /// On a Profile object, the describes property identifies the object described by the Profile.
    /// </summary>
    [JsonPropertyName("describes")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public IObject? Describes { get; set; }
}
