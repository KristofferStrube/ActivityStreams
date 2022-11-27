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
    /// <summary>
    /// The outbox stream contains activities the user has published, subject to the ability of the requestor to retrieve the activity (that is, the contents of the outbox are filtered by the permissions of the person reading it). If a user submits a request without Authorization the server should respond with all of the Public posts. This could potentially be all relevant objects published by the user, though the number of available items is left to the discretion of those implementing and deploying the server.
    /// </summary>
    /// <returns></returns>
    public static ILink GetOutbox<T>(this T obj) where T : Object, IActor
    {
        return ((JsonElement)obj.Body.outbox).Deserialize<ILink>();
    }
    /// <summary>
    /// The outbox stream contains activities the user has published, subject to the ability of the requestor to retrieve the activity (that is, the contents of the outbox are filtered by the permissions of the person reading it). If a user submits a request without Authorization the server should respond with all of the Public posts. This could potentially be all relevant objects published by the user, though the number of available items is left to the discretion of those implementing and deploying the server.
    /// </summary>
    public static void SetOutbox<T>(this T obj, ILink link) where T : Object, IActor
    {
        obj.Body.outbox = SerializeToElement(link);
    }

    /// <summary>
    /// The inbox stream contains all activities received by the actor. The server SHOULD filter content according to the requester's permission. In general, the owner of an inbox is likely to be able to access all of their inbox contents. Depending on access control, some other content may be public, whereas other content may require authentication for non-owner users, if they can access the inbox at all.
    /// </summary>
    public static ILink GetInbox<T>(this T obj) where T : Object, IActor
    {
        return ((JsonElement)obj.Body.inbox).Deserialize<ILink>();
    }
    /// <summary>
    /// The inbox stream contains all activities received by the actor. The server SHOULD filter content according to the requester's permission. In general, the owner of an inbox is likely to be able to access all of their inbox contents. Depending on access control, some other content may be public, whereas other content may require authentication for non-owner users, if they can access the inbox at all.
    /// </summary>
    public static void SetInbox<T>(this T obj, ILink link) where T : Object, IActor
    {
        obj.Body.inbox = SerializeToElement(link);
    }

    /// <summary>
    /// This is a list of everyone who has sent a Follow activity for the actor, added as a side effect. This is where one would find a list of all the actors that are following the actor. The followers collection MUST be either an OrderedCollection or a Collection and MAY be filtered on privileges of an authenticated user or as appropriate when no authentication is given.
    /// </summary>
    public static ILink GetFollowers<T>(this T obj) where T : Object, IActor
    {
        return ((JsonElement)obj.Body.followers).Deserialize<ILink>();
    }
    /// <summary>
    /// This is a list of everyone who has sent a Follow activity for the actor, added as a side effect. This is where one would find a list of all the actors that are following the actor. The followers collection MUST be either an OrderedCollection or a Collection and MAY be filtered on privileges of an authenticated user or as appropriate when no authentication is given.
    /// </summary>
    public static void SetFollowers<T>(this T obj, ILink link) where T : Object, IActor
    {
        obj.Body.followers = SerializeToElement(link);
    }

    /// <summary>
    /// This is a list of everybody that the actor has followed, added as a side effect. The following collection MUST be either an OrderedCollection or a Collection and MAY be filtered on privileges of an authenticated user or as appropriate when no authentication is given.
    /// </summary>
    public static ILink GetFollowing<T>(this T obj) where T : Object, IActor
    {
        return ((JsonElement)obj.Body.following).Deserialize<ILink>();
    }
    /// <summary>
    /// This is a list of everybody that the actor has followed, added as a side effect. The following collection MUST be either an OrderedCollection or a Collection and MAY be filtered on privileges of an authenticated user or as appropriate when no authentication is given.
    /// </summary>
    public static void SetFollowing<T>(this T obj, ILink link) where T : Object, IActor
    {
        obj.Body.following = SerializeToElement(link);
    }
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
