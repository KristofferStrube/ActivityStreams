using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Arrive : IntransitiveActiviy
{
    public Arrive() => Type = new List<string>() { "Arrive" };
}
