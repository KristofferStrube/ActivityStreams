namespace KristofferStrube.ActivityStreams;

public interface IIntransitiveActiviy : IObject
{
    IEnumerable<IObjectOrLink>? Actor { get; set; }
    IEnumerable<IObjectOrLink>? Instrument { get; set; }
    IEnumerable<IObjectOrLink>? Origin { get; set; }
    IEnumerable<IObjectOrLink>? Result { get; set; }
    IEnumerable<IObjectOrLink>? Target { get; set; }
}