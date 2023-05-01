namespace KristofferStrube.ActivityStreams;

public class Join : Activity
{
    public Join() => Type = new List<string>() { "Join" };
}
