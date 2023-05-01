namespace KristofferStrube.ActivityStreams;

public class TentativeReject : Reject
{
    public TentativeReject() => Type = new List<string>() { "TentativeReject" };
}
