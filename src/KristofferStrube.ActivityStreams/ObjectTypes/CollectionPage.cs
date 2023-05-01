using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class CollectionPage : Collection, ICollectionPageOrLink
{
    public CollectionPage() => Type = new List<string>() { "CollectionPage" };

    /// <summary>
    /// Identifies the Collection to which a CollectionPage objects items belong.
    /// </summary>
    [JsonPropertyName("partOf")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ICollectionOrLink? PartOf { get; set; }

    /// <summary>
    /// In a paged Collection, indicates the next page of items.
    /// </summary>
    [JsonPropertyName("next")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ICollectionPageOrLink? Next { get; set; }

    /// <summary>
    /// In a paged Collection, identifies the previous page of items.
    /// </summary>
    [JsonPropertyName("prev")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ICollectionPageOrLink? Prev { get; set; }
}
