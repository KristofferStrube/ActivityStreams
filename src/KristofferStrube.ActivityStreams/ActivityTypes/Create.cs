namespace KristofferStrube.ActivityStreams;

public class Create : Activity
{
    public Create() => Type = new List<string>() { "Create" };
}
