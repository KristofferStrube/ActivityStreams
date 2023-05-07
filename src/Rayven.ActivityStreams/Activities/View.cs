using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class View : Activity
{
    public View() => Type = new List<string>() { "View" };
}
