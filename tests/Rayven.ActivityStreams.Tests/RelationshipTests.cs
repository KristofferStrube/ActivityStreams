using Rayven.ActivityStreams.Actors;
using Rayven.ActivityStreams.Links;
using Rayven.ActivityStreams.Objects;
using Rayven.ActivityStreams.Ranges;

namespace Rayven.ActivityStreams.Tests;

public class RelationshipTests
{
    /// <summary>
    /// Example 139 taken from https://www.w3.org/TR/activitystreams-core/#jsonld
    /// </summary>
    [Fact]
    public void Example_139()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally is an acquaintance of John's",
              "type": "Relationship",
              "subject": {
                "type": "Person",
                "name": "Sally"
              },
              "relationship": "http://purl.org/vocab/relationship/acquaintanceOf",
              "object": {
                "type": "Person",
                "name": "John"
              }
            }
            """;

        // Act
        var ex139 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex139.Should().BeAssignableTo<Relationship>();
        ex139.As<Relationship>().Subject.As<Person>().Name.First().Should().Be("Sally");
        ex139.As<Relationship>().RelationshipAttribute.First().As<Link>().Href.Should().Be(new Uri("http://purl.org/vocab/relationship/acquaintanceOf"));
        ex139.As<Relationship>().Object.First().As<Person>().Name.First().Should().Be("John");
    }
}

