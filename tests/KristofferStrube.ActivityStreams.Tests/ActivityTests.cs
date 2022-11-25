namespace KristofferStrube.ActivityStreams.Tests;

public class ActivityTests
{
    [Fact]
    /// <remarks>Example 3 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-activity</remarks>
    public void Example_003()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Activity",
              "summary": "Sally did something to a note",
              "actor": {
                "type": "Person",
                "name": "Sally"
              },
              "object": {
                "type": "Note",
                "name": "A Note"
              }
            }
            """;

        // Act
        var ex3 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex3.Should().BeAssignableTo<Activity>();
        ex3.As<Activity>().Actor.Should().HaveCount(1);
        ex3.As<Activity>().Actor.First().As<Person>().Name.First().Should().Be("Sally");
    }

    [Fact]
    /// <remarks>Example 63 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-actor</remarks>
    public void Example_063()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally offered the Foo object",
              "type": "Offer",
              "actor": "http://sally.example.org",
              "object": "http://example.org/foo"
            }
            """;

        // Act
        var ex63 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex63.Should().BeAssignableTo<Offer>();
        ex63.As<Offer>().Actor.Should().HaveCount(1);
        ex63.As<Offer>().Actor.First().As<Link>().Href.Should().Be("http://sally.example.org");
    }

    [Fact]
    /// <remarks>Example 64 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-actor</remarks>
    public void Example_064()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally offered the Foo object",
              "type": "Offer",
              "actor": {
                "type": "Person",
                "id": "http://sally.example.org",
                "summary": "Sally"
              },
              "object": "http://example.org/foo"
            }
            """;

        // Act
        var ex64 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex64.Should().BeAssignableTo<Offer>();
        ex64.As<Offer>().Actor.Should().HaveCount(1);
        ex64.As<Offer>().Actor.First().As<Person>().Id.Should().Be("http://sally.example.org");
    }

    [Fact]
    /// <remarks>Example 65 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-actor</remarks>
    public void Example_065()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally and Joe offered the Foo object",
              "type": "Offer",
              "actor": [
                "http://joe.example.org",
                {
                  "type": "Person",
                  "id": "http://sally.example.org",
                  "name": "Sally"
                }
              ],
              "object": "http://example.org/foo"
            }
            """;

        // Act
        var ex65 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex65.Should().BeAssignableTo<Offer>();
        ex65.As<Offer>().Actor.Should().HaveCount(2);
        ex65.As<Offer>().Actor.First().As<Link>().Href.Should().Be("http://joe.example.org");
        ex65.As<Offer>().Actor.Last().As<Person>().Id.Should().Be("http://sally.example.org");
    }

    [Fact]
    /// <remarks>Example 97 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-object-term</remarks>
    public void Example_097()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally liked a post",
              "type": "Like",
              "actor": "http://sally.example.org",
              "object": "http://example.org/posts/1"
            }
            """;

        // Act
        var ex97 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex97.Should().BeAssignableTo<Like>();
        ex97.As<Like>().Object.Should().HaveCount(1);
        ex97.As<Like>().Object.First().As<Link>().Href.Should().Be("http://example.org/posts/1");
    }

    [Fact]
    /// <remarks>Example 98 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-object-term</remarks>
    public void Example_098()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Like",
              "actor": "http://sally.example.org",
              "object": {
                "type": "Note",
                "content": "A simple note"
              }
            }
            """;

        // Act
        var ex98 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex98.Should().BeAssignableTo<Like>();
        ex98.As<Like>().Object.Should().HaveCount(1);
        ex98.As<Like>().Object.First().As<Note>().Content.First().Should().Be("A simple note");
    }

    [Fact]
    /// <remarks>Example 99 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-object-term</remarks>
    public void Example_099()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally liked a note",
              "type": "Like",
              "actor": "http://sally.example.org",
              "object": [
                "http://example.org/posts/1",
                {
                  "type": "Note",
                  "summary": "A simple note",
                  "content": "That is a tree."
                }
              ]
            }
            """;

        // Act
        var ex99 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex99.Should().BeAssignableTo<Like>();
        ex99.As<Like>().Object.Should().HaveCount(2);
        ex99.As<Like>().Object.First().As<Link>().Href.Should().Be("http://example.org/posts/1");
        ex99.As<Like>().Object.Last().As<Note>().Content.First().Should().Be("That is a tree.");
    }

    [Fact]
    /// <remarks>Example 103 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-result</remarks>
    public void Example_103()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally checked that her flight was on time",
              "type": ["Activity", "http://www.verbs.example/Check"],
              "actor": "http://sally.example.org",
              "object": "http://example.org/flights/1",
              "result": {
                "type": "http://www.types.example/flightstatus",
                "name": "On Time"
              }
            }
            """;

        // Act
        var ex103 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex103.Should().BeAssignableTo<Offer>();
        ex103.As<Offer>().Target.Should().HaveCount(1);
        ex103.As<Offer>().Target.First().As<Person>().Name.First().Should().Be("John");
    }

    [Fact]
    /// <remarks>Example 106 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-target</remarks>
    public void Example_106()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally offered the post to John",
              "type": "Offer",
              "actor": "http://sally.example.org",
              "object": "http://example.org/posts/1",
              "target": "http://john.example.org"
            }
            """;

        // Act
        var ex106 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex106.Should().BeAssignableTo<Offer>();
        ex106.As<Offer>().Target.Should().HaveCount(1);
        ex106.As<Offer>().Target.First().As<Link>().Href.Should().Be("http://john.example.org");
    }

    [Fact]
    /// <remarks>Example 107 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-target</remarks>
    public void Example_107()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally offered the post to John",
              "type": "Offer",
              "actor": "http://sally.example.org",
              "object": "http://example.org/posts/1",
              "target": {
                "type": "Person",
                "name": "John"
              }
            }
            """;

        // Act
        var ex107 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex107.Should().BeAssignableTo<Offer>();
        ex107.As<Offer>().Target.Should().HaveCount(1);
        ex107.As<Offer>().Target.First().As<Person>().Name.First().Should().Be("John");
    }
}

