namespace KristofferStrube.ActivityStreams.Tests;

public class CollectionPageTests
{
    /// <summary>
    /// Example 95 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-next
    /// </summary>
    [Fact]
    public void Example_095()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Page 2 of Sally's blog posts",
              "type": "CollectionPage",
              "next": "http://example.org/collection?page=2",
              "items": [
                "http://example.org/posts/1",
                "http://example.org/posts/2",
                "http://example.org/posts/3"
              ]
            }
            """;

        // Act
        var ex95 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex95.Should().BeAssignableTo<CollectionPage>();
        ex95.As<CollectionPage>().Next.As<Link>().Href.Should().Be(new Uri("http://example.org/collection?page=2"));
    }

    /// <summary>
    /// Example 96 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-next
    /// </summary>
    [Fact]
    public void Example_096()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Page 2 of Sally's blog posts",
              "type": "CollectionPage",
              "next": {
                "type": "Link",
                "name": "Next Page",
                "href": "http://example.org/collection?page=2"
              },
              "items": [
                "http://example.org/posts/1",
                "http://example.org/posts/2",
                "http://example.org/posts/3"
              ]
            }
            """;

        // Act
        var ex96 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex96.Should().BeAssignableTo<CollectionPage>();
        ex96.As<CollectionPage>().Next.As<Link>().Name.First().Should().Be("Next Page");
        ex96.As<CollectionPage>().Next.As<Link>().Href.Should().Be(new Uri("http://example.org/collection?page=2"));
    }

    /// <summary>
    /// Example 100 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-prev
    /// </summary>
    [Fact]
    public void Example_100()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Page 1 of Sally's blog posts",
              "type": "CollectionPage",
              "prev": "http://example.org/collection?page=1",
              "items": [
                "http://example.org/posts/1",
                "http://example.org/posts/2",
                "http://example.org/posts/3"
              ]
            }
            """;

        // Act
        var ex100 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex100.Should().BeAssignableTo<CollectionPage>();
        ex100.As<CollectionPage>().Prev.As<Link>().Href.Should().Be(new Uri("http://example.org/collection?page=1"));
    }

    /// <summary>
    /// Example 101 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-prev
    /// </summary>
    [Fact]
    public void Example_101()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Page 1 of Sally's blog posts",
              "type": "CollectionPage",
              "prev": {
                "type": "Link",
                "name": "Previous Page",
                "href": "http://example.org/collection?page=1"
              },
              "items": [
                "http://example.org/posts/1",
                "http://example.org/posts/2",
                "http://example.org/posts/3"
              ]
            }
            """;

        // Act
        var ex101 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex101.Should().BeAssignableTo<CollectionPage>();
        ex101.As<CollectionPage>().Prev.As<Link>().Name.First().Should().Be("Previous Page");
        ex101.As<CollectionPage>().Prev.As<Link>().Href.Should().Be(new Uri("http://example.org/collection?page=1"));
    }

    /// <summary>
    /// Example 123 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-partof
    /// </summary>
    [Fact]
    public void Example_123()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Page 1 of Sally's notes",
              "type": "CollectionPage",
              "id": "http://example.org/collection?page=1",
              "partOf": "http://example.org/collection",
              "items": [
                {
                  "type": "Note",
                  "name": "Pizza Toppings to Try"
                },
                {
                  "type": "Note",
                  "name": "Thought about California"
                }
              ]
            }
            """;

        // Act
        var ex123 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex123.Should().BeAssignableTo<CollectionPage>();
        ex123.As<CollectionPage>().PartOf.As<Link>().Href.Should().Be(new Uri("http://example.org/collection"));
    }
}

