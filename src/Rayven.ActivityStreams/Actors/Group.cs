namespace Rayven.ActivityStreams.Actors;

public class Group : Actor
{
    public Group() => Type = new List<string>() { "Group" };
}
