using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Create : Activity
{
    public Create() => Type = new List<string>() { "Create" };
}
