namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> has joined the <see cref="Activity.Object"/>.
/// The <see cref="Activity.Target"/> and <see cref="Activity.Origin"/> typically have no defined meaning.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-join">See the API definition here</see>.</remarks>
public class Join : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Join"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Join()
    {
        Type = new List<string>() { "Join" };
    }
}
