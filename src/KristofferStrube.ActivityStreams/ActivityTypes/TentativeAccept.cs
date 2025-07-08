namespace KristofferStrube.ActivityStreams;

/// <summary>
/// A specialization of <see cref="Accept"/> indicating that the acceptance is tentative.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-tentativeaccept">See the API definition here</see>.</remarks>
public class TentativeAccept : Accept
{
    /// <summary>
    /// Constructs a new <see cref="TentativeAccept"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public TentativeAccept()
    {
        Type = new List<string>() { "TentativeAccept" };
    }
}
