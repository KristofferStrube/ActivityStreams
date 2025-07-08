namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> is calling the <see cref="Activity.Target"/>'s attention to the <see cref="Activity.Object"/>.
/// The <see cref="Activity.Origin"/> typically has no defined meaning.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-announce">See the API definition here</see>.</remarks>
public class Announce : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Announce"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Announce()
    {
        Type = new List<string>() { "Announce" };
    }
}
