namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Instances of <see cref="IntransitiveActivity"/> are a subtype of <see cref="Activity"/> representing intransitive actions.
/// The <see cref="Activity.Object"/> property is therefore inappropriate for these activities.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-intransitiveactivity">See the API definition here</see>.</remarks>
public class IntransitiveActivity : Activity
{
    /// <summary>
    /// Constructs a new <see cref="IntransitiveActivity"/> and sets its <see cref="IObjectOrLink.Type"/> accordingly.
    /// </summary>
    public IntransitiveActivity()
    {
        Type = new List<string>() { "IntransitiveActivity" };
    }

    /// <summary>
    /// Instances of IntransitiveActivity are a subtype of Activity representing intransitive actions. The object property is therefore inappropriate for these activities. 
    /// </summary>
    [Obsolete("The object property is inappropriate for intransitive activities.", true)]
#pragma warning disable IDE0051 // Remove unused private members
    private new IEnumerable<IObjectOrLink>? Object { get => base.Object; set => base.Object = value; }
#pragma warning restore IDE0051 // Remove unused private members
}
