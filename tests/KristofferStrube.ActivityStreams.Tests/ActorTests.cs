namespace KristofferStrube.ActivityStreams.Tests;

public class ActorTests
{
    /// <summary>
    /// Example 42 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-application
    /// </summary>
    [Fact]
    public void Example42()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Application",
              "name": "Exampletron 3000"
            }
            """;

        // Act
        IObjectOrLink ex42 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex42.Should().BeOfType<Application>()
            .Which.Name.Should().Contain("Exampletron 3000");
    }

    /// <summary>
    /// Example 43 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-group
    /// </summary>
    [Fact]
    public void Example43()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Group",
              "name": "Big Beards of Austin"
            }
            """;

        // Act
        IObjectOrLink ex43 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex43.Should().BeOfType<Group>()
            .Which.Name.Should().Contain("Big Beards of Austin");
    }

    /// <summary>
    /// Example 44 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-organization
    /// </summary>
    [Fact]
    public void Example44()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Organization",
              "name": "Example Co."
            }
            """;

        // Act
        IObjectOrLink ex44 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex44.Should().BeOfType<Organization>()
            .Which.Name.Should().Contain("Example Co.");
    }

    /// <summary>
    /// Example 45 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-person
    /// </summary>
    [Fact]
    public void Example45()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Person",
              "name": "Sally Smith"
            }
            """;

        // Act
        IObjectOrLink ex45 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex45.Should().BeOfType<Person>()
            .Which.Name.Should().Contain("Sally Smith");
    }

    /// <summary>
    /// Example 46 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-service
    /// </summary>
    [Fact]
    public void Example46()
    {
        // Arrange
        string input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Service",
              "name": "Acme Web Service"
            }
            """;

        // Act
        IObjectOrLink ex46 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex46.Should().BeOfType<Service>()
            .Which.Name.Should().Contain("Acme Web Service");
    }
}

