using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams.JsonLD;

public class ExpandedTermDefinition : ITermDefinition
{
    /// <summary>
    /// At times, all properties and types may come from the same vocabulary. JSON-LD's @vocab keyword allows an author to set a common prefix which is used as the vocabulary mapping and is used for all properties and types that do not match a term and are neither an IRI nor a compact IRI (i.e., they do not contain a colon).
    /// </summary>
    [JsonPropertyName("@vocab")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Uri? Vocab { get; set; }

    /// <summary>
    /// At times, it is important to annotate a string with its language. In JSON-LD this is possible in a variety of ways. First, it is possible to define a default language for a JSON-LD document by setting the @language key in the context.
    /// </summary>
    [JsonPropertyName("@language")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? Language { get; set; }
}
