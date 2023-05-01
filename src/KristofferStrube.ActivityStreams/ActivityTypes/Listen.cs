namespace KristofferStrube.ActivityStreams;

public class Listen : Activity
{
    public Listen() => Type = new List<string>() { "Listen" };
}
