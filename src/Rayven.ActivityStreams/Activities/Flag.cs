using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Flag : Activity
{
    public Flag() => Type = new List<string>() { "Flag" };
}
