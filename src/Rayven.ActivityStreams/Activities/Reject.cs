using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Reject : Activity
{
    public Reject() => Type = new List<string>() { "Reject" };
}
