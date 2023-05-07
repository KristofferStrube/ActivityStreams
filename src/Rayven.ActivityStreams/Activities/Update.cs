using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Update : Activity
{
    public Update() => Type = new List<string>() { "Update" };
}
