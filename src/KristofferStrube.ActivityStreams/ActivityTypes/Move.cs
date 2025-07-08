namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> has moved <see cref="Activity.Object"/> from <see cref="Activity.Origin"/> to <see cref="Activity.Target"/>.
/// If the <see cref="Activity.Origin"/> or <see cref="Activity.Target"/> are not specified, either can be determined by context.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-move">See the API definition here</see>.</remarks>
public class Move : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Move"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Move()
    {
        Type = new List<string>() { "Move" };
    }
}
