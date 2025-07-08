namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> is rejecting the <see cref="Activity.Object"/>.
/// The <see cref="Activity.Target"/> and <see cref="Activity.Origin"/> typically have no defined meaning.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-reject">See the API definition here</see>.</remarks>
public class Reject : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Reject"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Reject()
    {
        Type = new List<string>() { "Reject" };
    }
}
