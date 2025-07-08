namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents a service of any kind.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-service">See the API definition here</see>.</remarks>
public class Service : Actor
{
    /// <summary>
    /// Constructs a new <see cref="Service"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Service()
    {
        Type = new List<string>() { "Service" };
    }
}
