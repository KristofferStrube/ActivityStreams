namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> has left the <see cref="Activity.Object"/>.
/// The <see cref="Activity.Target"/> and <see cref="Activity.Origin"/> typically have no meaning.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-leave">See the API definition here</see>.</remarks>
public class Leave : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Leave"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Leave()
    {
        Type = new List<string>() { "Leave" };
    }
}
