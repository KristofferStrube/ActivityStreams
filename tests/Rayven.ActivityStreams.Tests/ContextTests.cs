using Rayven.ActivityStreams.JsonLD;
using Rayven.ActivityStreams.Objects;
using Rayven.ActivityStreams.Ranges;

namespace Rayven.ActivityStreams.Tests;

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
        ex1.Should().BeAssignableTo<Note>();
        ex1.As<Note>().JsonLDContext.Should().HaveCount(1);
        ex1.As<Note>().JsonLDContext.First().As<ReferenceTermDefinition>().Href.Should().Be(new Uri("https://www.w3.org/ns/activitystreams"));
    }

    /// <summary>
    /// Example 2 taken from https://www.w3.org/TR/activitystreams-core/#jsonld
    /// </summary>
    [Fact]
    public void Example_002()
    {
        // Arrange
        var input = """
            {
              "@context": {
                 "@vocab": "https://www.w3.org/ns/activitystreams",
                 "ext": "https://canine-extension.example/terms/",
                 "@language": "en"
              },
              "summary": "A note",
              "type": "Note",
              "content": "My dog has fleas.",
              "ext:nose": 0,
              "ext:smell": "terrible"
            }
            """;

        // Act
        var ex2 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex2.Should().BeAssignableTo<Note>();
        ex2.As<Note>().JsonLDContext.Should().HaveCount(1);
        ex2.As<Note>().JsonLDContext.First().As<ExpandedTermDefinition>().Vocab.Should().Be("https://www.w3.org/ns/activitystreams");
        ex2.As<Note>().JsonLDContext.First().As<ExpandedTermDefinition>().Language.Should().Be("en");
    }
}

