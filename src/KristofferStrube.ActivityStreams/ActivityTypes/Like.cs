namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> likes, recommends or endorses the <see cref="Activity.Object"/>.
/// The <see cref="Activity.Target"/> and <see cref="Activity.Origin"/> typically have no defined meaning.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-like">See the API definition here</see>.</remarks>
public class Like : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Like"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Like()
    {
        Type = new List<string>() { "Like" };
    }
}
