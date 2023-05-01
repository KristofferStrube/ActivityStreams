using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Actor : Object
{
    public Actor() => Type = new List<string>() { "Actor" };

    /// <summary>
    /// The outbox stream contains activities the user has published, subject to the ability of the requestor to retrieve the activity (that is, the contents of the outbox are filtered by the permissions of the person reading it). If a user submits a request without Authorization the server should respond with all of the Public posts. This could potentially be all relevant objects published by the user, though the number of available items is left to the discretion of those implementing and deploying the server.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("outbox")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ILink? Outbox { get; set; }

    /// <summary>
    /// The inbox stream contains all activities received by the actor. The server SHOULD filter content according to the requester's permission. In general, the owner of an inbox is likely to be able to access all of their inbox contents. Depending on access control, some other content may be public, whereas other content may require authentication for non-owner users, if they can access the inbox at all.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("inbox")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ILink? Inbox { get; set; }

    /// <summary>
    /// This is a list of everyone who has sent a Follow activity for the actor, added as a side effect. This is where one would find a list of all the actors that are following the actor. The followers collection MUST be either an OrderedCollection or a Collection and MAY be filtered on privileges of an authenticated user or as appropriate when no authentication is given.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("followers")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ILink? Followers { get; set; }

    /// <summary>
    /// This is a list of everybody that the actor has followed, added as a side effect. The following collection MUST be either an OrderedCollection or a Collection and MAY be filtered on privileges of an authenticated user or as appropriate when no authentication is given.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("following")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ILink? Following { get; set; }

    /// <summary>
    /// This is a list of every object from all of the actor's Like activities, added as a side effect. The liked collection MUST be either an OrderedCollection or a Collection and MAY be filtered on privileges of an authenticated user or as appropriate when no authentication is given.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("liked")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ILink? Liked { get; set; }

    /// <summary>
    /// A short username which may be used to refer to the actor, with no uniqueness guarantees.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("preferredUsername")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? PreferredUsername { get; set; }

    /// <summary>
    /// A json object which maps additional (typically server/domain-wide) endpoints which may be useful either for this actor or someone referencing this actor. This mapping may be nested inside the actor document as the value or may be a link to a JSON-LD document with these properties.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("endpoints")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public IEndpointsOrLink? Endpoints { get; set; }
}
