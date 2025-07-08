namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> has created the <see cref="Activity.Object"/>.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-create">See the API definition here</see>.</remarks>
public class Create : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Create"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Create()
    {
        Type = new List<string>() { "Create" };
    }
}
