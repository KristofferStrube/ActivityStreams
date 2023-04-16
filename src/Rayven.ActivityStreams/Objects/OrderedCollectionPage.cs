using System.Text.Json.Serialization;

namespace Rayven.ActivityStreams.Objects;

public class OrderedCollectionPage : CollectionPage
{
    /// <summary>
    /// A non-negative integer value identifying the relative position within the logical view of a strictly ordered collection.
    /// </summary>
    [JsonPropertyName("startIndex")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public uint? StartIndex { get; set; }
}
