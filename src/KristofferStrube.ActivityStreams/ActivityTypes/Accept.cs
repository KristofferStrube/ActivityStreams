namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> accepts the <see cref="Activity.Object"/>.
/// The <see cref="Activity.Target"/> property can be used in certain circumstances to indicate the context into which the <see cref="Activity.Object"/> has been accepted.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-accept">See the API definition here</see>.</remarks>
public class Accept : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Accept"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Accept()
    {
        Type = new List<string>() { "Accept" };
    }
}
