namespace KristofferStrube.ActivityStreams.JsonLD;

public class ReferenceTermDefinition : ITermDefinition
{
    public ReferenceTermDefinition(Uri href)
    {
        Href = href;
    }
    public Uri Href { get; set; }
}
