using KristofferStrube.ActivityStreams.JsonConverters;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Collection : Object, ICollectionOrLink
{
    public Collection() => Type = new List<string>() { "Collection" };

    /// <summary>
    /// Identifies the items contained in a collection. The items might be ordered or unordered.
    /// </summary>
    [JsonPropertyName("items")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? Items { get; set; }

    /// <summary>
    /// Identifies the items contained in a collection. The items might be ordered or unordered.
    /// </summary>
    [JsonPropertyName("orderedItems")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(OneOrMultipleConverter<IObjectOrLink>))]
    public IEnumerable<IObjectOrLink>? OrderedItems { get; set; }

    /// <summary>
    /// A non-negative integer specifying the total number of objects contained by the logical view of the collection. This number might not reflect the actual number of items serialized within the Collection object instance.
    /// </summary>
    [JsonPropertyName("totalItems")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public uint? TotalItems { get; set; }

    /// <summary>
    /// In a paged Collection, indicates the page that contains the most recently updated member items.
    /// </summary>
    [JsonPropertyName("current")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ICollectionPageOrLink? Current { get; set; }

    /// <summary>
    /// In a paged Collection, indicates the furthest preceeding page of items in the collection.
    /// </summary>
    [JsonPropertyName("first")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ICollectionPageOrLink? First { get; set; }

    /// <summary>
    /// In a paged Collection, indicates the furthest proceeding page of the collection.
    /// </summary>
    [JsonPropertyName("last")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ICollectionPageOrLink? Last { get; set; }
}
