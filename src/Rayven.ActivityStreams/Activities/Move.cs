using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Move : Activity
{
    public Move() => Type = new List<string>() { "Move" };
}
