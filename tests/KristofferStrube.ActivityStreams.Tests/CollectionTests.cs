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
    /// Example 74 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-current
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

