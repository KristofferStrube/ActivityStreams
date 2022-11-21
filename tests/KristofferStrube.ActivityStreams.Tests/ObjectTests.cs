namespace KristofferStrube.ActivityStreams.Tests;

public class ObjectTests
{
    [Fact]
    /// <remarks>Example taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-object</remarks>
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
        var object1 = Deserialize<Object>(input);

        // Assert
        object1.JsonLDContext.Should().Be(new Uri("https://www.w3.org/ns/activitystreams"));
        object1.Type.Should().HaveCount(1);
        object1.Type.First().Should().Be("Object");
        object1.TypeAsUri.First().Should().Be(new Uri("https://www.w3.org/ns/activitystreams/Object"));
        object1.Id.Should().Be(new Uri("http://www.test.example/object/1"));
        object1.Name.Should().Be("A Simple, non-specific object");
    }
}
