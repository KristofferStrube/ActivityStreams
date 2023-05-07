using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class TentativeReject : Reject
{
    public TentativeReject() => Type = new List<string>() { "TentativeReject" };
}
