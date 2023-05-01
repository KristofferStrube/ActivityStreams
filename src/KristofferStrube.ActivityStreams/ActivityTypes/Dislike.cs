namespace KristofferStrube.ActivityStreams;

public class Dislike : Activity
{
    public Dislike() => Type = new List<string>() { "Dislike" };
}
