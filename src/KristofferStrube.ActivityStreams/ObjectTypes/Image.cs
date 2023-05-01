namespace KristofferStrube.ActivityStreams;

public class Image : Document, IImageOrLink
{
    public Image() => Type = new List<string>() { "Image" };
}
