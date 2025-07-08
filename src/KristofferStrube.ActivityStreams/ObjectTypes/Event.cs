namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents any kind of event.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-event">See the API definition here</see>.</remarks>
public class Event : Object
{
    /// <summary>
    /// Constructs a new <see cref="Event"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Event()
    {
        Type = new List<string>() { "Event" };
    }
}
