namespace KristofferStrube.ActivityStreams;

public class Arrive : IntransitiveActivity
{
    public Arrive()
    {
        Type = new List<string>() { "Arrive" };
    }
}
