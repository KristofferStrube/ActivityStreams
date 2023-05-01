namespace KristofferStrube.ActivityStreams;

public class Accept : Activity
{
    public Accept() => Type = new List<string>() { "Accept" };
}
