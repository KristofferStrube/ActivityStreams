using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;
public class Remove : Activity
{
    public Remove() => Type = new List<string>() { "Remove" };
}
