namespace KristofferStrube.ActivityStreams;

public class Organization : Actor
{
    public Organization()
    {
        Type = new List<string>() { "Organization" };
    }
}
