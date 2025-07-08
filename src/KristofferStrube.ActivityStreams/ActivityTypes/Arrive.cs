namespace KristofferStrube.ActivityStreams;

/// <summary>
/// An <see cref="IntransitiveActivity"/> that indicates that the <see cref="Activity.Actor"/> has arrived at the <see cref="Object.Location"/>.
/// The <see cref="Activity.Origin"/> can be used to identify the context from which the <see cref="Activity.Actor"/> originated.
/// The <see cref="Activity.Target"/> typically has no defined meaning.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-arrive">See the API definition here</see>.</remarks>
public class Arrive : IntransitiveActivity
{
    /// <summary>
    /// Constructs a new <see cref="Arrive"/> intransitive activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Arrive()
    {
        Type = new List<string>() { "Arrive" };
    }
}
