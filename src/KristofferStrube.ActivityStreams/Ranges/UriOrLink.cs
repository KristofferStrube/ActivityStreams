using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(UriOrLinkConverter))]
public class UriOrLink
{
    private UriOrLink(object value)
    {
        Value = value;
    }

    public static implicit operator UriOrLink(Uri uri)
    {
        return new UriOrLink(uri);
    }

    public static implicit operator UriOrLink(Link link)
    {
        return new UriOrLink(link);
    }

    public override bool Equals(object? obj) => Value.Equals(obj);

    public object Value { get; init; }
}
