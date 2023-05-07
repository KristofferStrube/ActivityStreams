namespace Rayven.ActivityStreams.Objects;

public class Audio : Document
{
    public Audio() => Type = new List<string>() { "Audio" };
}
