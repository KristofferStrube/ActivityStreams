namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Represents an individual person.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-person">See the API definition here</see>.</remarks>
public class Person : Actor
{
    /// <summary>
    /// Constructs a new <see cref="Person"/> object and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Person()
    {
        Type = new List<string>() { "Person" };
    }
}
