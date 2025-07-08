namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> dislikes the <see cref="Activity.Object"/>.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-dislike">See the API definition here</see>.</remarks>
public class Dislike : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Dislike"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Dislike()
    {
        Type = new List<string>() { "Dislike" };
    }
}
