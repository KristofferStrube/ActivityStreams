using KristofferStrube.ActivityStreams.JsonConverters;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Text.Json.JsonSerializer;

namespace KristofferStrube.ActivityStreams.Tests;

public static class ObjectExtensions
{
    /// <summary>
    /// In addition to all the properties defined by the [Activity-Vocabulary], ActivityPub extends the Object by supplying the source property. The source property is intended to convey some sort of source from which the content markup was derived, as a form of provenance, or to support future editing by clients. In general, clients do the conversion from source to content, not the other way around.
    /// </summary>
    public static Source GetSource(this Object obj)
    {
        return ((JsonElement)obj.Body.source).Deserialize<Source>();
    }

    /// <summary>
    /// In addition to all the properties defined by the [Activity-Vocabulary], ActivityPub extends the Object by supplying the source property. The source property is intended to convey some sort of source from which the content markup was derived, as a form of provenance, or to support future editing by clients. In general, clients do the conversion from source to content, not the other way around.
    /// </summary>
    public static void SetSource(this Object obj, Source source)
    {
        obj.Body.source = SerializeToElement(source);
    }
}

public static class ActorExtensions
{
    public static ILink GetOutbox<T>(this T obj) where T : Object, IActor => ((JsonElement)obj.Body.outbox).Deserialize<ILink>();
    public static void SetOutbox<T>(this T obj, ILink link) where T : Object, IActor => obj.Body.outbox = SerializeToElement(link);

    public static ILink GetInbox<T>(this T obj) where T : Object, IActor => ((JsonElement)obj.Body.inbox).Deserialize<ILink>();
    public static void SetInbox<T>(this T obj, ILink link) where T : Object, IActor => obj.Body.inbox = SerializeToElement(link);

    public static ILink GetFollowers<T>(this T obj) where T : Object, IActor => ((JsonElement)obj.Body.followers).Deserialize<ILink>();
    public static void SetFollowers<T>(this T obj, ILink link) where T : Object, IActor => obj.Body.followers = SerializeToElement(link);

    public static ILink GetFollowing<T>(this T obj) where T : Object, IActor => ((JsonElement)obj.Body.following).Deserialize<ILink>();
    public static void SetFollowing<T>(this T obj, ILink link) where T : Object, IActor => obj.Body.following = SerializeToElement(link);
}

public class Source
{
    /// <summary>
    /// The content or textual representation of the Object encoded as a JSON string. By default, the value of content is HTML. The mediaType property can be used in the object to indicate a different content type.
    /// The content may be expressed using multiple language-tagged values.
    /// </summary>
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    [JsonPropertyName("content")]
    public IEnumerable<string> Content { get; set; }

    /// <summary>
    /// The content or textual representation of the Object encoded as a JSON string. By default, the value of content is HTML. The mediaType property can be used in the object to indicate a different content type.
    /// The content may be expressed using multiple language-tagged values.
    /// </summary>
    [JsonConverter(typeof(OneOrMultipleConverter<IDictionary<string, string>>))]
    [JsonPropertyName("contentMap")]
    public IEnumerable<IDictionary<string, string>> ContentMap { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    [JsonPropertyName("mediaType")]
    public string MediaType { get; set; }
}
