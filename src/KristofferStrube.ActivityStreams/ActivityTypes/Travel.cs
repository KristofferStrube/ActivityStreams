namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> is traveling to <see cref="Activity.Target"/> from <see cref="Activity.Origin"/>.
/// <see cref="Travel"/> is an <see cref="IntransitiveActivity"/> whose <see cref="Activity.Actor"/> specifies the direct object.
/// If the <see cref="Activity.Target"/> or <see cref="Activity.Origin"/> are not specified, either can be determined by context.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-travel">See the API definition here</see>.</remarks>
public class Travel : IntransitiveActivity
{
    /// <summary>
    /// Constructs a new <see cref="Travel"/> intransitive activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Travel()
    {
        Type = new List<string>() { "Travel" };
    }
}
