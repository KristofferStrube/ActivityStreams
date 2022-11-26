namespace KristofferStrube.ActivityStreams.Tests;

public class LinkTests
{
    /// <summary>
    /// Example 2 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-link
    /// </summary>
    [Fact]
    public void Example_002()
    {
        // Arrange
        // We have added a preview to the below example to test that.
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Link",
              "href": "http://example.org/abc",
              "hreflang": "en",
              "mediaType": "text/html",
              "name": "An example link",
              "preview": {
                "type": "Video",
                "name": "Trailer",
                "duration": "PT1M",
                "url": {
                  "href": "http://example.org/trailer.mkv",
                  "mediaType": "video/mkv"
                }
              }
            }
            """;

        // Act
        var ex2 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex2.Should().BeAssignableTo<Link>();
        ex2.As<Link>().Preview.Should().HaveCount(1);
        ex2.As<Link>().Preview.First().As<Video>().Name.First().Should().Be("Trailer");
    }

    /// <summary>
    /// Example 120 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-height
    /// </summary>
    [Fact]
    public void Example_120()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Link",
              "href": "http://example.org/image.png",
              "height": 100,
              "width": 100
            }
            """;

        // Act
        var ex120 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex120.Should().BeAssignableTo<Link>();
        ex120.As<Link>().Height.Should().Be(100);
    }

    /// <summary>
    /// Example 121 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-href
    /// </summary>
    [Fact]
    public void Example_121()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Link",
              "href": "http://example.org/abc",
              "mediaType": "text/html",
              "name": "Previous"
            }
            """;

        // Act
        var ex121 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex121.Should().BeAssignableTo<Link>();
        ex121.As<Link>().Href.Should().Be(new Uri("http://example.org/abc"));
    }

    /// <summary>
    /// Example 122 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-hreflang
    /// </summary>
    [Fact]
    public void Example_122()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Link",
              "href": "http://example.org/abc",
              "hreflang": "en",
              "mediaType": "text/html",
              "name": "Previous"
            }
            """;

        // Act
        var ex122 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex122.Should().BeAssignableTo<Link>();
        ex122.As<Link>().Hreflang.Should().Be("en");
    }

    /// <summary>
    /// Example 126 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-mediatype
    /// </summary>
    [Fact]
    public void Example_126()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Link",
              "href": "http://example.org/abc",
              "hreflang": "en",
              "mediaType": "text/html",
              "name": "Next"
            }
            """;

        // Act
        var ex126 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex126.Should().BeAssignableTo<Link>();
        ex126.As<Link>().MediaType.Should().Be("text/html");
    }

    /// <summary>
    /// Example 131 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-rel
    /// </summary>
    [Fact]
    public void Example_131()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Link",
              "href": "http://example.org/abc",
              "hreflang": "en",
              "mediaType": "text/html",
              "name": "Preview",
              "rel": ["canonical", "preview"]
            }
            """;

        // Act
        var ex131 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex131.Should().BeAssignableTo<Link>();
        ex131.As<Link>().Rel.Should().HaveCount(2);
        ex131.As<Link>().Rel.First().Should().Be("canonical");
        ex131.As<Link>().Rel.Last().Should().Be("preview");

        // We also test if we can get the name with this example
        ex131.As<Link>().Name.Should().HaveCount(1);
        ex131.As<Link>().Name.First().Should().Be("Preview");
    }

    /// <summary>
    /// Example 138 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-width
    /// </summary>
    [Fact]
    public void Example_138()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Link",
              "href": "http://example.org/image.png",
              "height": 100,
              "width": 100
            }
            """;

        // Act
        var ex138 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex138.Should().BeAssignableTo<Link>();
        ex138.As<Link>().Width.Should().Be(100);
    }
}

