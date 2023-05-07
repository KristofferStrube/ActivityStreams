namespace Rayven.ActivityStreams.Objects;

public class Note : Object
{
    public Note() => Type = new List<string>() { "Note" };
}
