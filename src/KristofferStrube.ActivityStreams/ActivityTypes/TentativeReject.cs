namespace KristofferStrube.ActivityStreams;

/// <summary>
/// A specialization of <see cref="Reject"/> in which the rejection is considered tentative.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-tentativereject">See the API definition here</see>.</remarks>
public class TentativeReject : Reject
{
    /// <summary>
    /// Constructs a new <see cref="TentativeReject"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public TentativeReject()
    {
        Type = new List<string>() { "TentativeReject" };
    }
}
