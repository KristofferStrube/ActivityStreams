namespace KristofferStrube.ActivityStreams;

/// <summary>
/// A specialization of <see cref="Offer"/> in which the <see cref="Activity.Actor"/> is extending an invitation for the <see cref="Activity.Object"/> to the <see cref="Activity.Target"/>.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-invite">See the API definition here</see>.</remarks>
public class Invite : Offer
{
    /// <summary>
    /// Constructs a new <see cref="Invite"/> offer activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Invite()
    {
        Type = new List<string>() { "Invite" };
    }
}
