namespace KristofferStrube.ActivityStreams;

public class Invite : Offer
{
    public Invite() => Type = new List<string>() { "Invite" };
}
