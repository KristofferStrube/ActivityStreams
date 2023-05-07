using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Invite : Offer
{
    public Invite() => Type = new List<string>() { "Invite" };
}
