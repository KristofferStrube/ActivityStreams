namespace KristofferStrube.ActivityStreams;

public class Group : Actor
{
    public Group() => Type = new List<string>() { "Group" };
}
