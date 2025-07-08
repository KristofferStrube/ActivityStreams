namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> has viewed the <see cref="Activity.Object"/>.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-view">See the API definition here</see>.</remarks>
public class View : Activity
{
    /// <summary>
    /// Constructs a new <see cref="View"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public View()
    {
        Type = new List<string>() { "View" };
    }
}
