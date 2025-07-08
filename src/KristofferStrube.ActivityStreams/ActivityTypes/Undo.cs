namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> is undoing the <see cref="Activity.Object"/>.
/// In most cases, the <see cref="Activity.Object"/> will be an <see cref="Activity"/> describing some previously performed action (for instance, a person may have previously "liked" an article but, for whatever reason, might choose to undo that like at some later point in time).
/// The <see cref="Activity.Target"/> and <see cref="Activity.Origin"/> typically have no defined meaning.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-undo">See the API definition here</see>.</remarks>
public class Undo : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Undo"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Undo()
    {
        Type = new List<string>() { "Undo" };
    }
}
