namespace KristofferStrube.ActivityStreams;

public class Mention : Link
{
    public Mention() => Type = new List<string>() { "Mention" };
}
