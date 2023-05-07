using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Announce : Activity
{
    public Announce() => Type = new List<string>() { "Announce" };
}
