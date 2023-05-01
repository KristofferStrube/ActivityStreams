namespace KristofferStrube.ActivityStreams;

public class Person : Actor
{
    public Person() => Type = new List<string>() { "Person" };
}
