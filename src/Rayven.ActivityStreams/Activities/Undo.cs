using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Undo : Activity
{
    public Undo() => Type = new List<string>() { "Undo" };
}
