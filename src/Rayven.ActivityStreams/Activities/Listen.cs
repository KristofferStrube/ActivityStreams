using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Listen : Activity
{
    public Listen() => Type = new List<string>() { "Listen" };
}
