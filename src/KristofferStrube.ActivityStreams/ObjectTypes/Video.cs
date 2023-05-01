namespace KristofferStrube.ActivityStreams;

public class Video : Document
{
    public Video() => Type = new List<string>() { "Video" };
}
