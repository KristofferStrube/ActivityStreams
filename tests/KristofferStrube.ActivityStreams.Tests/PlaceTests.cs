using KristofferStrube.ActivityStreams.JsonLD;

namespace KristofferStrube.ActivityStreams.Tests;

public class PlaceTests
{
    /// <summary>
    /// Example 112 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-accuracy
    /// </summary>
    [Fact]
    public void Example112()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "name": "Liu Gu Lu Cun, Pingdu, Qingdao, Shandong, China",
              "type": "Place",
              "latitude": 36.75,
              "longitude": 119.7667,
              "accuracy": 94.5
            }
            """;

        // Act
        var ex112 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex112.Should().BeAssignableTo<Place>();
        ex112.As<Place>().Accuracy.Should().Be(94.5f);
    }

    /// <summary>
    /// Example 113 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-altitude
    /// </summary>
    [Fact]
    public void Example113()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Place",
              "name": "Fresno Area",
              "altitude": 15.0,
              "latitude": 36.75,
              "longitude": 119.7667,
              "units": "miles"
            }
            """;

        // Act
        var ex113 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex113.Should().BeAssignableTo<Place>();
        ex113.As<Place>().Altitude.Should().Be(15.0f);
    }

    /// <summary>
    /// Example 124 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-latitude
    /// </summary>
    [Fact]
    public void Example124()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Place",
              "name": "Fresno Area",
              "latitude": 36.75,
              "longitude": 119.7667,
              "radius": 15,
              "units": "miles"
            }
            """;

        // Act
        var ex124 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex124.Should().BeAssignableTo<Place>();
        ex124.As<Place>().Latitude.Should().Be(36.75f);
    }

    /// <summary>
    /// Example 125 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-longitude
    /// </summary>
    [Fact]
    public void Example125()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Place",
              "name": "Fresno Area",
              "latitude": 36.75,
              "longitude": 119.7667,
              "radius": 15,
              "units": "miles"
            }
            """;

        // Act
        var ex125 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex125.Should().BeAssignableTo<Place>();
        ex125.As<Place>().Longitude.Should().Be(119.7667f);
    }

    /// <summary>
    /// Example 130 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-radius
    /// </summary>
    [Fact]
    public void Example130()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Place",
              "name": "Fresno Area",
              "latitude": 36.75,
              "longitude": 119.7667,
              "radius": 15,
              "units": "miles"
            }
            """;

        // Act
        var ex130 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex130.Should().BeAssignableTo<Place>();
        ex130.As<Place>().Radius.Should().Be(15f);
    }

    /// <summary>
    /// Example 136 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-units
    /// </summary>
    [Fact]
    public void Example136()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Place",
              "name": "Fresno Area",
              "latitude": 36.75,
              "longitude": 119.7667,
              "radius": 15,
              "units": "miles"
            }
            """;

        // Act
        var ex136 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex136.Should().BeAssignableTo<Place>();
        ex136.As<Place>().Units.Should().Be("miles");
    }
}

