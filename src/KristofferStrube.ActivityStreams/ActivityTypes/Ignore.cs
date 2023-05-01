namespace KristofferStrube.ActivityStreams;

public class Ignore : Activity
{
    public Ignore() => Type = new List<string>() { "Ignore" };
}
