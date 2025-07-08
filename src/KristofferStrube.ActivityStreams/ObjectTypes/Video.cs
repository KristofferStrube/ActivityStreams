namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents a video document of any kind.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-video">See the API definition here</see>.</remarks>
public class Video : Document
{
    /// <summary>
    /// Constructs a new <see cref="Video"/> document object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Video()
    {
        Type = new List<string>() { "Video" };
    }
}
