namespace KristofferStrube.ActivityStreams.JsonLD;

/// <summary>
/// A minimal reference representation of a JSON-LD context definition.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/json-ld11/#advanced-context-usage">See the API definition here</see>.</remarks>
public class ReferenceTermDefinition : ITermDefinition
{
    /// <summary>
    /// Constructs a <see cref="ReferenceTermDefinition"/> that can be used to reference a JSON-LD context definition.
    /// </summary>
    /// <param name="href"></param>
    public ReferenceTermDefinition(Uri href)
    {
        Href = href;
    }

    /// <summary>
    /// The link to the JSON-LD context definition.
    /// </summary>
    public Uri Href { get; set; }
}
