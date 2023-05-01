namespace KristofferStrube.ActivityStreams;

public class Page : Document
{
    public Page() => Type = new List<string>() { "Page" };
}
