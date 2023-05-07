namespace Rayven.ActivityStreams.Objects;

public class OrderedCollection : Collection
{
    public OrderedCollection() => Type = new List<string>() { "OrderedCollection" };
}
