using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(DateTimeBooleanObjectOrLinkConverter))]
public class DateTimeBooleanObjectOrLink
{
    public object? Value;
}
