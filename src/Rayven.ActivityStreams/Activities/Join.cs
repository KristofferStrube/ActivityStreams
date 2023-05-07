using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Join : Activity
{
    public Join() => Type = new List<string>() { "Join" };
}
