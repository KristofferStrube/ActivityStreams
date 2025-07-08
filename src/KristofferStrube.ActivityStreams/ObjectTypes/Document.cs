namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents a document of any kind.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-document">See the API definition here</see>.</remarks>
public class Document : Object
{
    /// <summary>
    /// Constructs a new <see cref="Document"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Document()
    {
        Type = new List<string>() { "Document" };
    }
}
