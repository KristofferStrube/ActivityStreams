namespace KristofferStrube.ActivityStreams;

/// <summary>
/// A subtype of <see cref="Collection"/> in which members of the logical collection are assumed to always be strictly ordered.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-orderedcollection">See the API definition here</see>.</remarks>
public class OrderedCollection : Collection
{
    /// <summary>
    /// Constructs a new <see cref="OrderedCollection"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public OrderedCollection()
    {
        Type = new List<string>() { "OrderedCollection" };
    }
}
