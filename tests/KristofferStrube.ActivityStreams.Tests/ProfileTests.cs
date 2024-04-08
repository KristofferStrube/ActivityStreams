namespace KristofferStrube.ActivityStreams.Tests;

public class ProfileTests
{
    /// <summary>
    /// Example 141 taken from https://www.w3.org/TR/activitystreams-core/#jsonld
    /// </summary>
    [Fact]
    public void Example_141()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally's profile",
              "type": "Profile",
              "describes": {
                "type": "Person",
                "name": "Sally"
              },
              "url": "http://sally.example.org"
            }
            """;

        // Act
        IObjectOrLink ex141 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex141.Should().BeAssignableTo<Profile>();
        ex141.As<Profile>().Describes.As<Person>().Name.First().Should().Be("Sally");
    }
}

