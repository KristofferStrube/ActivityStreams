namespace KristofferStrube.ActivityStreams;

public class Reject : Activity
{
    public Reject() => Type = new List<string>() { "Reject" };
}
