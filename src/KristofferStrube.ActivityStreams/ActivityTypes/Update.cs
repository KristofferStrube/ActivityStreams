namespace KristofferStrube.ActivityStreams;

public class Update : Activity
{
    public Update() => Type = new List<string>() { "Update" };
}
