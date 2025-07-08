using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Used to represent ordered subsets of items from an <see cref="OrderedCollection"/>.
/// Refer to the Activity Streams 2.0 Core for a complete description of the <see cref="OrderedCollectionPage"/> object.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-orderedcollectionpage">See the API definition here</see>.</remarks>
public class OrderedCollectionPage : CollectionPage
{
    /// <summary>
    /// Constructs a new <see cref="OrderedCollectionPage"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public OrderedCollectionPage()
    {
        Type = new List<string>() { "OrderedCollectionPage" };
    }

    /// <summary>
    /// A non-negative integer value identifying the relative position within the logical view of a strictly ordered collection.
    /// </summary>
    [JsonPropertyName("startIndex")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public uint? StartIndex { get; set; }
}
