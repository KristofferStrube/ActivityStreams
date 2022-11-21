namespace KristofferStrube.ActivityStreams;

public class ImageOrLink
{
    private ImageOrLink(object value)
    {
        Value = value;
    }

    public static implicit operator ImageOrLink(Image img)
    {
        return new ImageOrLink(img);
    }

    public static implicit operator ImageOrLink(Link link)
    {
        return new ImageOrLink(link);
    }

    public object Value { get; init; }
}
