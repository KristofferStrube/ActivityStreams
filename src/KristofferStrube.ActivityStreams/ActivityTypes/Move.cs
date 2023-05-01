namespace KristofferStrube.ActivityStreams;

public class Move : Activity
{
    public Move() => Type = new List<string>() { "Move" };
}
