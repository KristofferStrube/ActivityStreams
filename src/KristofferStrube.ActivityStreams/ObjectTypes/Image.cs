namespace KristofferStrube.ActivityStreams;

/// <summary>
/// An image document of any kind
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-image">See the API definition here</see>.</remarks>
public class Image : Document, IImageOrLink
{
    /// <summary>
    /// Constructs a new <see cref="Image"/> document object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Image()
    {
        Type = new List<string>() { "Image" };
    }
}
