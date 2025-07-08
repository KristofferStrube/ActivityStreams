namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> has deleted the <see cref="Activity.Object"/>.
/// If specified, the <see cref="Activity.Origin"/> indicates the context from which the <see cref="Activity.Object"/> was deleted.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-delete">See the API definition here</see>.</remarks>
public class Delete : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Delete"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Delete()
    {
        Type = new List<string>() { "Delete" };
    }
}
