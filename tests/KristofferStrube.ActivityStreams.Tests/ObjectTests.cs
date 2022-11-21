namespace KristofferStrube.ActivityStreams.Tests;

public class ObjectTests
{
    [Fact]
    /// <remarks>Example 1 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-object</remarks>
    public void Example_1()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Object",
              "id": "http://www.test.example/object/1",
              "name": "A Simple, non-specific object"
            }
            """;

        // Act
        var ex1 = Deserialize<Object>(input);

        // Assert
        ex1.JsonLDContext.Should().Be(new Uri("https://www.w3.org/ns/activitystreams"));
        ex1.Type.Should().HaveCount(1);
        ex1.Type.First().Should().Be("Object");
        ex1.TypeAsUri.First().Should().Be(new Uri("https://www.w3.org/ns/activitystreams/Object"));
        ex1.Id.Should().Be("http://www.test.example/object/1");
        ex1.Name.Should().Be("A Simple, non-specific object");
    }

    [Fact]
    /// <remarks>Example 61 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-id</remarks>
    public void Example_61()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "name": "Foo",
              "id": "http://example.org/foo"
            }
            """;

        // Act
        var ex61 = Deserialize<Object>(input);

        // Assert
        ex61.Id.Should().Be("http://example.org/foo");
        ex61.IdAsUri.Should().Be(new Uri("http://example.org/foo"));
    }

    [Fact]
    /// <remarks>Example 62 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-type</remarks>
    public void Example_62()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A foo",
              "type": "http://example.org/Foo"
            }
            """;

        // Act
        var ex62 = Deserialize<Object>(input);

        // Assert
        ex62.Type.Should().HaveCount(1);
        ex62.Type.First().Should().Be("http://example.org/Foo");
        ex62.TypeAsUri.First().Should().Be(new Uri("http://example.org/Foo"));
    }

    [Fact]
    /// <remarks>Example 66 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-attachment</remarks>
    public void Example_66()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Note",
              "name": "Have you seen my cat?",
              "attachment": [
                {
                  "type": "Image",
                  "content": "This is what he looks like.",
                  "url": "http://example.org/cat.jpeg"
                }
              ]
            }
            """;

        // Act
        var ex66 = Deserialize<Object>(input);

        // Assert
        ex66.Attachment.Should().HaveCount(1);
    }
}

