namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Indicates that the <see cref="Activity.Actor"/> is "flagging" the <see cref="Activity.Object"/>.
/// Flagging is defined in the sense common to many social platforms as reporting content as being inappropriate for any number of reasons.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-flag">See the API definition here</see>.</remarks>
public class Flag : Activity
{
    /// <summary>
    /// Constructs a new <see cref="Flag"/> activity and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public Flag()
    {
        Type = new List<string>() { "Flag" };
    }
}
