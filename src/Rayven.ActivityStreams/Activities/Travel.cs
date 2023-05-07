using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Travel : IntransitiveActiviy
{
    public Travel() => Type = new List<string>() { "Travel" };
}
