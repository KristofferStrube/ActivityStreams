using Rayven.ActivityStreams.Objects;
using Rayven.ActivityStreams.Ranges;

namespace Rayven.ActivityStreams.Tests;

public class TombstoneTests
{
    /// <summary>
    /// Example 142 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-formertype
    /// </summary>
    [Fact]
    public void Example_142()
    {
        // Arrange
        var input = """
            {
            "@context": "https://www.w3.org/ns/activitystreams",
            "summary": "This image has been deleted",
            "type": "Tombstone",
            "formerType": "Image",
            "url": "http://example.org/image/2"
            }
            """;

        // Act
        var ex142 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex142.Should().BeAssignableTo<Tombstone>();
        ex142.As<Tombstone>().FormerType.First().Should().Be("Image");
    }

    /// <summary>
    /// Example 143 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-deleted
    /// </summary>
    [Fact]
    public void Example_143()
    {
        // Arrange
        var input = """
            {
            "@context": "https://www.w3.org/ns/activitystreams",
            "summary": "This image has been deleted",
            "type": "Tombstone",
            "deleted": "2016-05-03T00:00:00Z"
            }
            """;

        // Act
        var ex143 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex143.Should().BeAssignableTo<Tombstone>();
        ex143.As<Tombstone>().Deleted.Should().Be(DateTime.Parse("2016-05-03T00:00:00Z", styles: System.Globalization.DateTimeStyles.AdjustToUniversal));
    }
}

