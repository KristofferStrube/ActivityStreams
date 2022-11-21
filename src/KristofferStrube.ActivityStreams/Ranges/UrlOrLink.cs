namespace KristofferStrube.ActivityStreams.Ranges;

public class UriOrLink
{
    private UriOrLink(object value)
    {
        Value = value;
    }

    public static implicit operator UriOrLink(Uri img)
    {
        return new UriOrLink(img);
    }

    public static implicit operator UriOrLink(Link link)
    {
        return new UriOrLink(link);
    }

    public object Value { get; init; }
}
