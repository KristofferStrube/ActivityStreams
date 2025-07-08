namespace KristofferStrube.ActivityStreams;

/// <summary>
/// A specialized <see cref="Link"/> that represents an @mention.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-mention">See the API definition here</see>.</remarks>
public class Mention : Link
{
    /// <summary>
    /// Constructs a new <see cref="Mention"/> link and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Mention()
    {
        Type = new List<string>() { "Mention" };
    }
}
