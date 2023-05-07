using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class TentativeAccept : Accept
{
    public TentativeAccept() => Type = new List<string>() { "TentativeAccept" };
}
