namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents a formal or informal collective of Actors.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-group">See the API definition here</see>.</remarks>
public class Group : Actor
{
    /// <summary>
    /// Constructs a new <see cref="Group"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Group()
    {
        Type = new List<string>() { "Group" };
    }
}
