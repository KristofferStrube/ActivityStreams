namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> is blocking the <see cref="Activity.Object"/>.
/// Blocking is a stronger form of <see cref="Ignore"/>.
/// The typical use is to support social systems that allow one user to block activities or content of other users.
/// The <see cref="Activity.Target"/> and <see cref="Activity.Origin"/> typically have no defined meaning.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-block">See the API definition here</see>.</remarks>
public class Block : Ignore
{
    /// <summary>
    /// Constructs a new <see cref="Block"/> ignore activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Block()
    {
        Type = new List<string>() { "Block" };
    }
}
