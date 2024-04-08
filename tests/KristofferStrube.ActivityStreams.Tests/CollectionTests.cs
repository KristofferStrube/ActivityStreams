namespace KristofferStrube.ActivityStreams.Tests;

public class CollectionTests
{
    /// <summary>
    /// Example 74 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-current
    /// </summary>
    [Fact]
    public void Example_074()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally's blog posts",
              "type": "Collection",
              "totalItems": 3,
              "current": "http://example.org/collection",
              "items": [
                "http://example.org/posts/1",
                "http://example.org/posts/2",
                "http://example.org/posts/3"
              ]
            }
            """;

        // Act
        IObjectOrLink ex74 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex74.Should().BeAssignableTo<Collection>();
        ex74.As<Collection>().Current.As<Link>().Href.Should().Be(new Uri("http://example.org/collection"));
    }

    /// <summary>
    /// Example 75 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-current
    /// </summary>
    [Fact]
    public void Example_075()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally's blog posts",
              "type": "Collection",
              "totalItems": 3,
              "current": {
                "type": "Link",
                "summary": "Most Recent Items",
                "href": "http://example.org/collection"
              },
              "items": [
                "http://example.org/posts/1",
                "http://example.org/posts/2",
                "http://example.org/posts/3"
              ]
            }
            """;

        // Act
        IObjectOrLink ex75 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex75.Should().BeAssignableTo<Collection>();
        ex75.As<Collection>().Current.As<Link>().Href.Should().Be(new Uri("http://example.org/collection"));
    }

    /// <summary>
    /// Example 76 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-first
    /// </summary>
    [Fact]
    public void Example_076()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally's blog posts",
              "type": "Collection",
              "totalItems": 3,
              "first": "http://example.org/collection?page=0"
            }
            """;

        // Act
        IObjectOrLink ex76 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex76.Should().BeAssignableTo<Collection>();
        ex76.As<Collection>().First.As<Link>().Href.Should().Be(new Uri("http://example.org/collection?page=0"));
    }

    /// <summary>
    /// Example 77 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-first
    /// </summary>
    [Fact]
    public void Example_077()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally's blog posts",
              "type": "Collection",
              "totalItems": 3,
              "first": {
                "type": "Link",
                "summary": "First Page",
                "href": "http://example.org/collection?page=0"
              }
            }
            """;

        // Act
        IObjectOrLink ex77 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex77.Should().BeAssignableTo<Collection>();
        ex77.As<Collection>().First.As<Link>().Href.Should().Be(new Uri("http://example.org/collection?page=0"));
    }

    /// <summary>
    /// Example 86 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-last
    /// </summary>
    [Fact]
    public void Example_086()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A collection",
              "type": "Collection",
              "totalItems": 3,
              "last": "http://example.org/collection?page=1"
            }
            """;

        // Act
        IObjectOrLink ex86 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex86.Should().BeAssignableTo<Collection>();
        ex86.As<Collection>().Last.As<Link>().Href.Should().Be(new Uri("http://example.org/collection?page=1"));
    }

    /// <summary>
    /// Example 87 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-last
    /// </summary>
    [Fact]
    public void Example_087()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A collection",
              "type": "Collection",
              "totalItems": 5,
              "last": {
                "type": "Link",
                "summary": "Last Page",
                "href": "http://example.org/collection?page=1"
              }
            }
            """;

        // Act
        IObjectOrLink ex87 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex87.Should().BeAssignableTo<Collection>();
        ex87.As<Collection>().Last.As<Link>().Href.Should().Be(new Uri("http://example.org/collection?page=1"));
    }

    /// <summary>
    /// Example 89 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-items
    /// </summary>
    [Fact]
    public void Example_089()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally's notes",
              "type": "Collection",
              "totalItems": 2,
              "items": [
                {
                  "type": "Note",
                  "name": "Reminder for Going-Away Party"
                },
                {
                  "type": "Note",
                  "name": "Meeting 2016-11-17"
                }
              ]
            }
            """;

        // Act
        IObjectOrLink ex89 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex89.Should().BeAssignableTo<Collection>();
        ex89.As<Collection>().Items.Should().HaveCount(2);
        ex89.As<Collection>().Items.ElementAt(0).As<Note>().Name.First().Should().Be("Reminder for Going-Away Party");
        ex89.As<Collection>().Items.ElementAt(1).As<Note>().Name.First().Should().Be("Meeting 2016-11-17");
    }

    /// <summary>
    /// Example 90 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-items
    /// </summary>
    [Fact]
    public void Example_090()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally's notes",
              "type": "OrderedCollection",
              "totalItems": 2,
              "orderedItems": [
                {
                  "type": "Note",
                  "name": "Meeting 2016-11-17"
                },
                {
                  "type": "Note",
                  "name": "Reminder for Going-Away Party"
                }
              ]
            }
            """;

        // Act
        IObjectOrLink ex90 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex90.Should().BeAssignableTo<OrderedCollection>();
        ex90.As<OrderedCollection>().OrderedItems.Should().HaveCount(2);
        ex90.As<OrderedCollection>().OrderedItems.ElementAt(0).As<Note>().Name.First().Should().Be("Meeting 2016-11-17");
        ex90.As<OrderedCollection>().OrderedItems.ElementAt(1).As<Note>().Name.First().Should().Be("Reminder for Going-Away Party");
    }

    /// <summary>
    /// Example 135 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-totalitems
    /// </summary>
    [Fact]
    public void Example_135()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally's notes",
              "type": "Collection",
              "totalItems": 2,
              "items": [
                {
                  "type": "Note",
                  "name": "Which Staircase Should I Use"
                },
                {
                  "type": "Note",
                  "name": "Something to Remember"
                }
              ]
            }
            """;

        // Act
        IObjectOrLink ex135 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex135.Should().BeAssignableTo<Collection>();
        ex135.As<Collection>().TotalItems.Should().Be(2);
    }
}

