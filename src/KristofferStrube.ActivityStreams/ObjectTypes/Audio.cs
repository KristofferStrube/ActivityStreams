namespace KristofferStrube.ActivityStreams;

public class Audio : Document
{
    public Audio() => Type = new List<string>() { "Audio" };
}
