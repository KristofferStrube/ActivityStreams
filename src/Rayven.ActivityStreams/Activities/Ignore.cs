using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Ignore : Activity
{
    public Ignore() => Type = new List<string>() { "Ignore" };
}
