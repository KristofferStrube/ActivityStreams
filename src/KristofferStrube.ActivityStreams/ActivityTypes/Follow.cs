namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> is "following" the <see cref="Activity.Object"/>.
/// Following is defined in the sense typically used within Social systems in which the actor is interested in any activity performed by or on the object.
/// The <see cref="Activity.Target"/> and <see cref="Activity.Origin"/> typically have no defined meaning.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-follow">See the API definition here</see>.</remarks>
public class Follow : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Follow"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Follow()
    {
        Type = new List<string>() { "Follow" };
    }
}
