namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents a Web Page.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-page">See the API definition here</see>.</remarks>
public class Page : Document
{
    /// <summary>
    /// Constructs a new <see cref="Page"/> document object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Page()
    {
        Type = new List<string>() { "Page" };
    }
}
