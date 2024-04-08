namespace KristofferStrube.ActivityStreams;

public class Travel : IntransitiveActivity
{
    public Travel()
    {
        Type = new List<string>() { "Travel" };
    }
}
