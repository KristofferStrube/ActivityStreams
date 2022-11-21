namespace KristofferStrube.ActivityStreams;

public class ObjectOrLink
{
    private ObjectOrLink(object value)
    {
        Value = value;
    }

    public static implicit operator ObjectOrLink(Object obj)
    {
        return new ObjectOrLink(obj);
    }

    public static implicit operator ObjectOrLink(Link link)
    {
        return new ObjectOrLink(link);
    }

    public object Value { get; init; }
}
