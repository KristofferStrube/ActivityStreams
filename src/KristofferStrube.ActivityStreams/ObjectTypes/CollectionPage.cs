using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Used to represent distinct subsets of items from a <see cref="Collection"/>.
/// Refer to the Activity Streams 2.0 Core for a complete description of the CollectionPage object.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-collectionpage">See the API definition here</see>.</remarks>
public class CollectionPage : Collection, ICollectionPageOrLink
{
    /// <summary>
    /// Constructs a new <see cref="CollectionPage"/> and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public CollectionPage()
    {
        Type = new List<string>() { "CollectionPage" };
    }

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
