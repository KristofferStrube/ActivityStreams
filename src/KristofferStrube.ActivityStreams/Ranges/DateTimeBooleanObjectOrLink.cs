using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents something that can be a <see cref="DateTime"/>, <see cref="bool"/>, <see cref="Object"/>, or <see cref="Link"/>.
/// </summary>
[JsonConverter(typeof(DateTimeBooleanObjectOrLinkConverter))]
public class DateTimeBooleanObjectOrLink
{
    /// <summary>
    /// The value that it represents. It will be a <see cref="DateTime"/>, <see cref="bool"/>, <see cref="Object"/>, or <see cref="Link"/>.
    /// </summary>
    public object? Value { get; set; }
}
