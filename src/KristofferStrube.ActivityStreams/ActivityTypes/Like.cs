namespace KristofferStrube.ActivityStreams;

public class Like : Activity
{
    public Like() => Type = new List<string>() { "Like" };
}
