namespace KristofferStrube.ActivityStreams;

public class Add : Activity
{
    public Add() => Type = new List<string>() { "Add" };
}
