namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents a short written work typically less than a single paragraph in length.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-note">See the API definition here</see>.</remarks>
public class Note : Object
{
    /// <summary>
    /// Constructs a new <see cref="Note"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Note()
    {
        Type = new List<string>() { "Note" };
    }
}
