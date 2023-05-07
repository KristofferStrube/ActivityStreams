using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Read : Activity
{
    public Read() => Type = new List<string>() { "Read" };
}
