using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Collection : Object
{
    /// <summary>
    /// Identifies the items contained in a collection. The items might be ordered or unordered.
    /// </summary>
    [JsonPropertyName("items")]
    public IEnumerable<IObjectOrLink> Items { get; set; }

    /// <summary>
    /// Identifies the items contained in a collection. The items might be ordered or unordered.
    /// </summary>
    [JsonPropertyName("orderedItems")]
    public IEnumerable<IObjectOrLink> OrderedItems { get; set; }
}
