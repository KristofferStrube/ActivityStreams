namespace KristofferStrube.ActivityStreams;

public class Delete : Activity
{
    public Delete() => Type = new List<string>() { "Delete" };
}
