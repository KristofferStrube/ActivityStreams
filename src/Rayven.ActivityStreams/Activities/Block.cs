using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Block : Ignore
{
    public Block() => Type = new List<string>() { "Block" };
}
