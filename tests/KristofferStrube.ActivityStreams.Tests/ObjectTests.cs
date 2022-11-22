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
        ex62.Summary.First().Should().Be("A foo");
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
        ex66.Attachment.First().Should().BeAssignableTo<Image>();
        ex66.Attachment.First().As<Image>().Content.Should().Be("This is what he looks like.");
        ex66.Attachment.First().As<Image>().Url.Should().HaveCount(1);
        ex66.Attachment.First().As<Image>().Url.First().Should().Be(new Uri("http://example.org/cat.jpeg"));
    }

    [Fact]
    /// <remarks>Example 67 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-attributedto</remarks>
    public void Example_67()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Image",
              "name": "My cat taking a nap",
              "url": "http://example.org/cat.jpeg",
              "attributedTo": [
                {
                  "type": "Person",
                  "name": "Sally"
                }
              ]
            }
            """;

        // Act
        var ex67 = Deserialize<Image>(input);

        // Assert
        ex67.AttributedTo.Should().HaveCount(1);
        ex67.AttributedTo.First().Should().BeAssignableTo<Person>();
        ex67.AttributedTo.First().As<Person>().Name.Should().Be("Sally");
    }

    [Fact]
    /// <remarks>Example 68 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-attributedto</remarks>
    public void Example_68()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Image",
              "name": "My cat taking a nap",
              "url": "http://example.org/cat.jpeg",
              "attributedTo": [
                "http://joe.example.org",
                {
                  "type": "Person",
                  "name": "Sally"
                }
              ]
            }
            """;

        // Act
        var ex68 = Deserialize<Image>(input);

        // Assert
        ex68.AttributedTo.Should().HaveCount(2);
        ex68.AttributedTo.ElementAt(0).Should().BeAssignableTo<Link>();
        ex68.AttributedTo.ElementAt(0).As<Link>().Href.Should().Be(new Uri("http://joe.example.org"));
        ex68.AttributedTo.ElementAt(1).Should().BeAssignableTo<Object>();
        ex68.AttributedTo.ElementAt(1).As<Object>().Name.Should().Be("Sally");
    }

    [Fact]
    /// <remarks>Example 69 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-audience</remarks>
    public void Example_69()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "name": "Holiday announcement",
              "type": "Note",
              "content": "Thursday will be a company-wide holiday. Enjoy your day off!",
              "audience": {
                "type": "http://example.org/Organization",
                "name": "ExampleCo LLC"
              }
            }
            """;

        // Act
        var ex69 = Deserialize<Note>(input);

        // Assert
        ex69.Audience.Should().HaveCount(1);
        ex69.Audience.First().Should().BeAssignableTo<Object>();
        ex69.Audience.First().As<Object>().Name.Should().Be("ExampleCo LLC");
    }
}

