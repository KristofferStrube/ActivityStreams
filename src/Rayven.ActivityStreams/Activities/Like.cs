using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Like : Activity
{
    public Like() => Type = new List<string>() { "Like" };
}
