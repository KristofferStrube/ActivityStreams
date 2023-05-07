using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;

public class Accept : Activity
{
    public Accept() => Type = new List<string>() { "Accept" };
}
