using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class OrderedCollectionPage : CollectionPage
{
    public OrderedCollectionPage() => Type = new List<string>() { "OrderedCollectionPage" };

    /// <summary>
    /// A non-negative integer value identifying the relative position within the logical view of a strictly ordered collection.
    /// </summary>
    [JsonPropertyName("startIndex")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public uint? StartIndex { get; set; }
}
