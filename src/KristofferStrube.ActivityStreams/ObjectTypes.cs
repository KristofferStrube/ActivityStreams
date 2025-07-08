namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Holds information about what types each <see cref="IObjectOrLink.Type"/> maps to.
/// </summary>
public static class ObjectTypes
{
    /// <summary>
    /// A map from names of types to actual types. Used for deciding what type to deserialize <see cref="IObject"/>s as.
    /// </summary>
    public static readonly Dictionary<string, Type> Types = new()
    {
        { nameof(Object), typeof(Object) },
        { nameof(Collection), typeof(Collection) },
        { nameof(CollectionPage), typeof(CollectionPage) },
        { nameof(OrderedCollection), typeof(OrderedCollection) },
        { nameof(OrderedCollectionPage), typeof(OrderedCollectionPage) },
        { nameof(Relationship), typeof(Relationship) },
        { nameof(Article), typeof(Article) },
        { nameof(Document), typeof(Document) },
        { nameof(Audio), typeof(Audio) },
        { nameof(Image), typeof(Image) },
        { nameof(Video), typeof(Video) },
        { nameof(Note), typeof(Note) },
        { nameof(Page), typeof(Page) },
        { nameof(Event), typeof(Event) },
        { nameof(Place), typeof(Place) },
        { nameof(Profile), typeof(Profile) },
        { nameof(Tombstone), typeof(Tombstone) },
        // Actors
        { nameof(Application), typeof(Application) },
        { nameof(Group), typeof(Group) },
        { nameof(Organization), typeof(Organization) },
        { nameof(Person), typeof(Person) },
        { nameof(Service), typeof(Service) },
        // Activities
        { nameof(Activity), typeof(Activity) },
        { nameof(IntransitiveActivity), typeof(IntransitiveActivity) },
        { nameof(Accept), typeof(Accept) },
        { nameof(Add), typeof(Add) },
        { nameof(Announce), typeof(Announce) },
        { nameof(Arrive), typeof(Arrive) },
        { nameof(Block), typeof(Block) },
        { nameof(Create), typeof(Create) },
        { nameof(Delete), typeof(Delete) },
        { nameof(Dislike), typeof(Dislike) },
        { nameof(Flag), typeof(Flag) },
        { nameof(Follow), typeof(Follow) },
        { nameof(Ignore), typeof(Ignore) },
        { nameof(Invite), typeof(Invite) },
        { nameof(Join), typeof(Join) },
        { nameof(Leave), typeof(Leave) },
        { nameof(Like), typeof(Like) },
        { nameof(Listen), typeof(Listen) },
        { nameof(Move), typeof(Move) },
        { nameof(Offer), typeof(Offer) },
        { nameof(Question), typeof(Question) },
        { nameof(Reject), typeof(Reject) },
        { nameof(Read), typeof(Read) },
        { nameof(Remove), typeof(Remove) },
        { nameof(TentativeReject), typeof(TentativeReject) },
        { nameof(TentativeAccept), typeof(TentativeAccept) },
        { nameof(Travel), typeof(Travel) },
        { nameof(Undo), typeof(Undo) },
        { nameof(Update), typeof(Update) },
        { nameof(View), typeof(View) },
    };
}
