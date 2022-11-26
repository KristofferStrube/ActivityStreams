namespace KristofferStrube.ActivityStreams;

internal static class ObjectTypes
{
    internal static readonly Dictionary<string, Type> Types = new()
    {
        { "Object", typeof(Object) },
        { "Collection", typeof(Collection) },
        { "CollectionPage", typeof(CollectionPage) },
        { "OrderedCollection", typeof(OrderedCollection) },
        { "Document", typeof(Document) },
        { "Image", typeof(Image) },
        { "Video", typeof(Video) },
        { "Note", typeof(Note) },
        { "Place", typeof(Place) },
        { "Event", typeof(Event) },
        // Actors
        { "Application", typeof(Application) },
        { "Organísation", typeof(Organisation) },
        { "Person", typeof(Person) },
        { "Service", typeof(Service) },
        // Activities
        { "Activity", typeof(Activity) },
        { "IntransitiveActiviy", typeof(IntransitiveActiviy) },
        { "Move", typeof(Move) },
        { "Listen", typeof(Listen) },
        { "Offer", typeof(Offer) },
        { "Like", typeof(Like) }
    };
}
