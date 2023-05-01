namespace KristofferStrube.ActivityStreams;

public class Leave : Activity
{
    public Leave() => Type = new List<string>() { "Leave" };
}
