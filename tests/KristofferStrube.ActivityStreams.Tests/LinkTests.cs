namespace KristofferStrube.ActivityStreams.Tests;

public class LinkTests
{
    [Fact]
    /// <remarks>Example 121 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-href</remarks>
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
}

