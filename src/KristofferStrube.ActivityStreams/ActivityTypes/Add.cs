namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> has added the <see cref="Activity.Object"/> to the <see cref="Activity.Target"/>.
/// If the <see cref="Activity.Target"/> property is not explicitly specified, the target would need to be determined implicitly by context.
/// The <see cref="Activity.Origin"/> can be used to identify the context from which the <see cref="Activity.Object"/> originated.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-add">See the API definition here</see>.</remarks>
public class Add : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Add"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Add()
    {
        Type = new List<string>() { "Add" };
    }
}
