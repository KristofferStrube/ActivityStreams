namespace KristofferStrube.ActivityStreams;

public class Announce : Activity
{
    public Announce() => Type = new List<string>() { "Announce" };
}
