using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Dislike : Activity
{
    public Dislike() => Type = new List<string>() { "Dislike" };
}
