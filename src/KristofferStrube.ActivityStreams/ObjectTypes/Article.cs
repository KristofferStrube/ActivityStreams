namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents any kind of multi-paragraph written work.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-article">See the API definition here</see>.</remarks>
public class Article : Object
{
    /// <summary>
    /// Constructs a new <see cref="Article"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Article()
    {
        Type = new List<string>() { "Article" };
    }
}
