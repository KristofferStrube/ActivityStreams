using KristofferStrube.ActivityStreams.JsonLD;
using System.CodeDom.Compiler;
using System.Text.Json;

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
              "content": "My dog has fleas.",
              "summary": "A note",
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Note"
            }
            """;

        // Act
        var ex1 = Deserialize<IObjectOrLink>(input);

        var equivalentNote = new Note()
        {
            Summary = new List<string>() { "A note" },
            Content = new List<string>() { "My dog has fleas." }
        };

        // Assert
        Serialize<IObjectOrLink>(equivalentNote, new JsonSerializerOptions() { WriteIndented = true }).Should().Be(input);

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

