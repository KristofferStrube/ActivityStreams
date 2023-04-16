using Rayven.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace Rayven.ActivityStreams.Ranges;

[JsonConverter(typeof(DateTimeBooleanObjectOrLinkConverter))]
public class DateTimeBooleanObjectOrLink
{
    public object? Value;
}
