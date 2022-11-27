using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonConverter(typeof(ObjectConverter))]
public interface IObject : IObjectOrLink
{
    IEnumerable<IObjectOrLink>? Attachment { get; set; }
    IEnumerable<IObjectOrLink>? AttributedTo { get; set; }
    IEnumerable<IObjectOrLink>? Audience { get; set; }
    IEnumerable<IObjectOrLink>? Bcc { get; set; }
    IEnumerable<IObjectOrLink>? Bto { get; set; }
    IEnumerable<IObjectOrLink>? Cc { get; set; }
    IEnumerable<IObjectOrLink>? Context { get; set; }
    IEnumerable<IObjectOrLink>? Generator { get; set; }
    IEnumerable<IImageOrLink>? Icon { get; set; }
    IEnumerable<IImageOrLink>? Image { get; set; }
    IEnumerable<IObjectOrLink>? InReplyTo { get; set; }
    IEnumerable<IObjectOrLink>? Location { get; set; }
    Collection? Replies { get; set; }
    IEnumerable<IObjectOrLink>? Tag { get; set; }
    IEnumerable<IObjectOrLink>? To { get; set; }
    IEnumerable<ILink>? Url { get; set; }
    IEnumerable<string>? Content { get; set; }
    IEnumerable<IDictionary<string, string>>? ContentMap { get; set; }
    IEnumerable<IDictionary<string, string>>? NameMap { get; set; }
    TimeSpan? Duration { get; set; }
    DateTime? EndTime { get; set; }
    DateTime? Published { get; set; }
    DateTime? StartTime { get; set; }
    IEnumerable<string>? Summary { get; set; }
    IEnumerable<IDictionary<string, string>>? SummaryMap { get; set; }
    DateTime? Updated { get; set; }
}
