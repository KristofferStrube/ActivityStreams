namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> has read the <see cref="Activity.Object"/>.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-read">See the API definition here</see>.</remarks>
public class Read : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Read"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Read()
    {
        Type = new List<string>() { "Read" };
    }
}
