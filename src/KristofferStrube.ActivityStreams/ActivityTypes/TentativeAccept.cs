namespace KristofferStrube.ActivityStreams;

public class TentativeAccept : Accept
{
    public TentativeAccept() => Type = new List<string>() { "TentativeAccept" };
}
