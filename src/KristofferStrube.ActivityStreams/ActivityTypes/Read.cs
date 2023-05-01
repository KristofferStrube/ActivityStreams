namespace KristofferStrube.ActivityStreams;

public class Read : Activity
{
    public Read() => Type = new List<string>() { "Read" };
}
