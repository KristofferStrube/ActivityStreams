namespace KristofferStrube.ActivityStreams;

public class IntransitiveActivity : Activity
{
    public IntransitiveActivity()
    {
        Type = new List<string>() { "IntransitiveActivity" };
    }

    /// <summary>
    /// Instances of IntransitiveActivity are a subtype of Activity representing intransitive actions. The object property is therefore inappropriate for these activities. 
    /// </summary>
    [Obsolete("The object property is inappropriate for intransitive activities.", true)]
    private new IEnumerable<IObjectOrLink>? Object { get => base.Object; set => base.Object = value; }
}
