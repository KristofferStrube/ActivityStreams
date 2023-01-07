namespace KristofferStrube.ActivityStreams.Tests;

public class OrderedCollectionPageTests
{
    /// <summary>
    /// Example 132 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-startindex
    /// </summary>
    [Fact]
    public void Example_132()
    {
        // Arrange
        // We changed the below to have startIndex not be the default value 0.
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Page 1 of Sally's notes",
              "type": "OrderedCollectionPage",
              "startIndex": 1,
              "orderedItems": [
                {
                  "type": "Note",
                  "name": "Density of Water"
                },
                {
                  "type": "Note",
                  "name": "Air Mattress Idea"
                }
              ]
            }
            """;

        // Act
        var ex132 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex132.Should().BeAssignableTo<OrderedCollectionPage>();
        ex132.As<OrderedCollectionPage>().StartIndex.Should().Be(1);

        // Serialize and check for intactness
        Serialize(Deserialize<IObjectOrLink>(Serialize(Deserialize<IObjectOrLink>(input)))).Should().Be(Serialize(Deserialize<IObjectOrLink>(input)));
    }
}

