namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents an organization.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-organization">See the API definition here</see>.</remarks>
public class Organization : Actor
{
    /// <summary>
    /// Constructs a new <see cref="Organization"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Organization()
    {
        Type = new List<string>() { "Organization" };
    }
}
