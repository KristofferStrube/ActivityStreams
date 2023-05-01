namespace KristofferStrube.ActivityStreams;

public class Follow : Activity
{
    public Follow() => Type = new List<string>() { "Follow" };
}
