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
        var ex1 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex1.Should().BeAssignableTo<Object>();
        ex1.As<Object>().JsonLDContext.Should().Be(new Uri("https://www.w3.org/ns/activitystreams"));
        ex1.As<Object>().Id.Should().Be("http://www.test.example/object/1");
        ex1.As<Object>().Name.Should().Be("A Simple, non-specific object");
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
        var ex61 = Deserialize<ObjectOrLink>(input);

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
        var ex62 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex62.Type.Should().Be("http://example.org/Foo");
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
        var ex66 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex66.Should().BeAssignableTo<Note>();
        ex66.As<Note>().Attachment.Should().HaveCount(1);
        ex66.As<Note>().Attachment.First().Should().BeAssignableTo<Image>();
        ex66.As<Note>().Attachment.First().As<Image>().Content.Should().Be("This is what he looks like.");
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
        var ex67 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex67.Should().BeAssignableTo<Image>();
        ex67.As<Image>().AttributedTo.Should().HaveCount(1);
        ex67.As<Image>().AttributedTo.First().Should().BeAssignableTo<Person>();
        ex67.As<Image>().AttributedTo.First().As<Person>().Name.Should().Be("Sally");
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
        var ex68 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex68.Should().BeAssignableTo<Image>();
        ex68.As<Image>().AttributedTo.Should().HaveCount(2);
        ex68.As<Image>().AttributedTo.ElementAt(0).Should().BeAssignableTo<Link>();
        ex68.As<Image>().AttributedTo.ElementAt(0).As<Link>().Href.Should().Be(new Uri("http://joe.example.org"));
        ex68.As<Image>().AttributedTo.ElementAt(1).Should().BeAssignableTo<Object>();
        ex68.As<Image>().AttributedTo.ElementAt(1).As<Object>().Name.Should().Be("Sally");
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
        var ex69 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex69.Should().BeAssignableTo<Note>();
        ex69.As<Note>().Audience.Should().HaveCount(1);
        ex69.As<Note>().Audience.First().Type.Should().Be("http://example.org/Organization");
    }

    [Fact]
    /// <remarks>Example 70 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-bcc</remarks>
    public void Example_70()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally offered a post to John",
              "type": "Offer",
              "actor": "http://sally.example.org",
              "object": "http://example.org/posts/1",
              "target": "http://john.example.org",
              "bcc": [ "http://joe.example.org" ]
            }
            """;

        // Act
        var ex70 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex70.Should().BeAssignableTo<Offer>();
        ex70.As<Offer>().Bcc.Should().HaveCount(1);
        ex70.As<Offer>().Bcc.First().Should().BeAssignableTo<Link>();
        ex70.As<Offer>().Bcc.First().As<Link>().Href.Should().Be(new Uri("http://joe.example.org"));
    }

    [Fact]
    /// <remarks>Example 71 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-bto</remarks>
    public void Example_71()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally offered a post to John",
              "type": "Offer",
              "actor": "http://sally.example.org",
              "object": "http://example.org/posts/1",
              "target": "http://john.example.org",
              "bto": [ "http://joe.example.org" ]
            }
            """;

        // Act
        var ex71 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex71.Should().BeAssignableTo<Offer>();
        ex71.As<Offer>().Bto.Should().HaveCount(1);
        ex71.As<Offer>().Bto.First().Should().BeAssignableTo<Link>();
        ex71.As<Offer>().Bto.First().As<Link>().Href.Should().Be(new Uri("http://joe.example.org"));
    }

    [Fact]
    /// <remarks>Example 72 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-cc</remarks>
    public void Example_72()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally offered a post to John",
              "type": "Offer",
              "actor": "http://sally.example.org",
              "object": "http://example.org/posts/1",
              "target": "http://john.example.org",
              "cc": [ "http://joe.example.org" ]
            }
            """;

        // Act
        var ex72 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex72.Should().BeAssignableTo<Offer>();
        ex72.As<Offer>().Cc.Should().HaveCount(1);
        ex72.As<Offer>().Cc.First().Should().BeAssignableTo<Link>();
        ex72.As<Offer>().Cc.First().As<Link>().Href.Should().Be(new Uri("http://joe.example.org"));
    }

    [Fact]
    /// <remarks>Example 73 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-context</remarks>
    public void Example_73()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Activities in context 1",
              "type": "Collection",
              "items": [
                {
                  "type": "Offer",
                  "actor": "http://sally.example.org",
                  "object": "http://example.org/posts/1",
                  "target": "http://john.example.org",
                  "context": "http://example.org/contexts/1"
                },
                {
                  "type": "Like",
                  "actor": "http://joe.example.org",
                  "object": "http://example.org/posts/2",
                  "context": "http://example.org/contexts/1"
                }
              ]
            }
            """;

        // Act
        var ex73 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex73.Should().BeAssignableTo<Collection>();
        ex73.As<Collection>().Items.First().As<Offer>().Context.First().As<Link>().Href.Should().Be("http://example.org/contexts/1");
        ex73.As<Collection>().Items.Last().As<Like>().Context.First().As<Link>().Href.Should().Be("http://example.org/contexts/1");
    }

    [Fact]
    /// <remarks>Example 78 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-generator</remarks>
    public void Example_78()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A simple note",
              "type": "Note",
              "content": "This is all there is.",
              "generator": {
                "type": "Application",
                "name": "Exampletron 3000"
              }
            }
            """;

        // Act
        var ex78 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex78.Should().BeAssignableTo<Note>();
        ex78.As<Note>().Generator.Should().HaveCount(1);
        ex78.As<Note>().Generator.First().Should().BeAssignableTo<Application>();
        ex78.As<Note>().Generator.First().As<Application>().Name.Should().Be("Exampletron 3000");
    }
}

