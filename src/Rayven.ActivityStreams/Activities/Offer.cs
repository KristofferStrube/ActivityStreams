using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Offer : Activity
{
    public Offer() => Type = new List<string>() { "Offer" };
}
