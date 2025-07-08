namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> is removing the <see cref="Activity.Object"/>.
/// If specified, the <see cref="Activity.Origin"/> indicates the context from which the <see cref="Activity.Object"/> is being removed.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-remove">See the API definition here</see>.</remarks>
public class Remove : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Remove"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Remove()
    {
        Type = new List<string>() { "Remove" };
    }
}
