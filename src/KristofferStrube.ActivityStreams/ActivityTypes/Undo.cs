namespace KristofferStrube.ActivityStreams;

public class Undo : Activity
{
    public Undo() => Type = new List<string>() { "Undo" };
}
