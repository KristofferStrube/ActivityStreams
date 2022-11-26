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
        var input = """
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
        var ex74 = Deserialize<IObjectOrLink>(input);

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
        var input = """
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
        var ex75 = Deserialize<IObjectOrLink>(input);

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
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally's blog posts",
              "type": "Collection",
              "totalItems": 3,
              "first": "http://example.org/collection?page=0"
            }
            """;

        // Act
        var ex76 = Deserialize<IObjectOrLink>(input);

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
        var input = """
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
        var ex77 = Deserialize<IObjectOrLink>(input);

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
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A collection",
              "type": "Collection",
              "totalItems": 3,
              "last": "http://example.org/collection?page=1"
            }
            """;

        // Act
        var ex86 = Deserialize<IObjectOrLink>(input);

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
        var input = """
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
        var ex87 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex87.Should().BeAssignableTo<Collection>();
        ex87.As<Collection>().Last.As<Link>().Href.Should().Be(new Uri("http://example.org/collection?page=1"));
    }

    /// <summary>
    /// Example 135 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-totalitems
    /// </summary>
    [Fact]
    public void Example_135()
    {
        // Arrange
        var input = """
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
        var ex135 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex135.Should().BeAssignableTo<Collection>();
        ex135.As<Collection>().TotalItems.Should().Be(2);
    }
}

