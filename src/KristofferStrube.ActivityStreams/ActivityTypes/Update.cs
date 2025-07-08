namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> has updated the <see cref="Activity.Object"/>.
/// Note, however, that this vocabulary does not define a mechanism for describing the actual set of modifications made to <see cref="Activity.Object"/>.
/// The <see cref="Activity.Target"/> and <see cref="Activity.Origin"/> typically have no defined meaning.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-update">See the API definition here</see>.</remarks>
public class Update : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Update"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Update()
    {
        Type = new List<string>() { "Update" };
    }
}
