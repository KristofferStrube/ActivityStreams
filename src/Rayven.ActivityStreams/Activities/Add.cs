using Rayven.ActivityStreams.Activities;

namespace Rayven.ActivityStreams;

public class Add : Activity
{
    public Add() => Type = new List<string>() { "Add" };
}
