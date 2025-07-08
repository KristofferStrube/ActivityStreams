namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents an audio document of any kind.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-audio">See the API definition here</see>.</remarks>
public class Audio : Document
{
    /// <summary>
    /// Constructs a new <see cref="Audio"/> document object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Audio()
    {
        Type = new List<string>() { "Audio" };
    }
}
