namespace KristofferStrube.ActivityStreams;

public class Remove : Activity
{
    public Remove() => Type = new List<string>() { "Remove" };
}
