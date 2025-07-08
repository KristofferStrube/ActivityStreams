namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Describes a software application.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-application">See the API definition here</see>.</remarks>
public class Application : Actor
{
    /// <summary>
    /// Constructs a new <see cref="Application"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Application()
    {
        Type = new List<string>() { "Application" };
    }
}
