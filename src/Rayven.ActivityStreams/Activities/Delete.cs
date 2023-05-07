using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Delete : Activity
{
    public Delete() => Type = new List<string>() { "Delete" };
}
