using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Endpoints : IEndpointsOrLink
{
    /// <summary>
    /// Endpoint URI so this actor's clients may access remote ActivityStreams objects which require authentication to access. To use this endpoint, the client posts an x-www-form-urlencoded id parameter with the value being the id of the requested ActivityStreams object.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("proxyUrl")]
    public Uri? ProxyUrl { get; set; }

    /// <summary>
    /// If OAuth 2.0 bearer tokens [RFC6749] [RFC6750] are being used for authenticating client to server interactions, this endpoint specifies a URI at which a browser-authenticated user may obtain a new authorization grant.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("oauthAuthorizationEndpoint")]
    public Uri? OauthAuthorizationEndpoint { get; set; }

    /// <summary>
    ///If OAuth 2.0 bearer tokens [RFC6749] [RFC6750] are being used for authenticating client to server interactions, this endpoint specifies a URI at which a client may acquire an access token.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("oauthTokenEndpoint")]
    public Uri? OauthTokenEndpoint { get; set; }

    /// <summary>
    /// If Linked Data Signatures and HTTP Signatures are being used for authentication and authorization, this endpoint specifies a URI at which browser-authenticated users may authorize a client's public key for client to server interactions.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("provideClientKey")]
    public Uri? ProvideClientKey { get; set; }

    /// <summary>
    /// If Linked Data Signatures and HTTP Signatures are being used for authentication and authorization, this endpoint specifies a URI at which a client key may be signed by the actor's key for a time window to act on behalf of the actor in interacting with foreign servers.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("signClientKey")]
    public Uri? SignClientKey { get; set; }

    /// <summary>
    /// An optional endpoint used for wide delivery of publicly addressed activities and activities sent to followers. sharedInbox endpoints SHOULD also be publicly readable OrderedCollection objects containing objects addressed to the Public special collection. Reading from the sharedInbox endpoint MUST NOT present objects which are not addressed to the Public endpoint.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonPropertyName("sharedInbox")]
    public Uri? SharedInbox { get; set; }

    /// <summary>
    /// Additional Endpoints are mapped to this property.
    /// </summary>
    /// <remarks>This is only available as a part of ActivityPub.</remarks>
    [JsonExtensionData]
    public Dictionary<string, Uri>? ExtensionData { get; set; }
}