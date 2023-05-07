namespace Rayven.ActivityStreams.Actors;

public class Person : Actor
{
    public Person() => Type = new List<string>() { "Person" };
}
