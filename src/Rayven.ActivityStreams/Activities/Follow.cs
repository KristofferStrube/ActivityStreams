using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Follow : Activity
{
    public Follow() => Type = new List<string>() { "Follow" };
}
