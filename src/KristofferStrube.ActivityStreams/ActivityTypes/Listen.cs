namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> has listened to the <see cref="Activity.Object"/>.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-listen">See the API definition here</see>.</remarks>
public class Listen : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Listen"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Listen()
    {
        Type = new List<string>() { "Listen" };
    }
}
