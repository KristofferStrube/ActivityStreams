namespace KristofferStrube.ActivityStreams;

public class Block : Ignore
{
    public Block() => Type = new List<string>() { "Block" };
}
