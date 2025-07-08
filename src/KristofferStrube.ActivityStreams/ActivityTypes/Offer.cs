namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> is offering the <see cref="Activity.Object"/>.
/// If specified, the <see cref="Activity.Target"/> indicates the entity to which the <see cref="Activity.Object"/> is being offered.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-offer">See the API definition here</see>.</remarks>
public class Offer : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Offer"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Offer()
    {
        Type = new List<string>() { "Offer" };
    }
}
