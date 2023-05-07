using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Leave : Activity
{
    public Leave() => Type = new List<string>() { "Leave" };
}
