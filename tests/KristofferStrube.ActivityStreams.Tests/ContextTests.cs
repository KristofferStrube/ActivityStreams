namespace KristofferStrube.ActivityStreams.Tests;

public class ContextTests
{
    /// <summary>
    /// Example 1 taken from https://www.w3.org/TR/activitystreams-core/#jsonld
    /// </summary>
    [Fact]
    public void Example_001()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A note",
              "type": "Note",
              "content": "My dog has fleas."
            }
            """;

        // Act
        var ex1 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex1.Should().BeAssignableTo<Object>();
        ex1.As<Object>().JsonLDContext.Should().Be(new Uri("https://www.w3.org/ns/activitystreams"));
        ex1.As<Object>().Type.Should().Contain("Note");
    }
}

