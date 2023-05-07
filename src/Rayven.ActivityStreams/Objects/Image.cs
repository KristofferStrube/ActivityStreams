using Rayven.ActivityStreams.Ranges;

namespace Rayven.ActivityStreams.Objects;

public class Image : Document, IImageOrLink
{
    public Image() => Type = new List<string>() { "Image" };
}
