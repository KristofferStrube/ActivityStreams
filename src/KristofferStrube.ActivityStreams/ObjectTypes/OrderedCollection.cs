namespace KristofferStrube.ActivityStreams;

public class OrderedCollection : Collection
{
    public OrderedCollection() => Type = new List<string>() { "OrderedCollection" };
}
