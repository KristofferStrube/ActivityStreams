using KristofferStrube.ActivityStreams.JsonLD;

namespace KristofferStrube.ActivityStreams.Tests;

public class QuestionTests
{
    /// <summary>
    /// Example 91 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-oneof
    /// </summary>
    [Fact]
    public void Example_091()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Question",
              "name": "What is the answer?",
              "oneOf": [
                {
                  "type": "Note",
                  "name": "Option A"
                },
                {
                  "type": "Note",
                  "name": "Option B"
                }
              ]
            }
            """;

        // Act
        var ex91 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex91.Should().BeAssignableTo<Question>();
        ex91.As<Question>().OneOf.Should().HaveCount(2);
        ex91.As<Question>().OneOf.ElementAt(0).As<Note>().Name.First().Should().Be("Option A");
        ex91.As<Question>().OneOf.ElementAt(1).As<Note>().Name.First().Should().Be("Option B");
    }

    /// <summary>
    /// Example 92 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-anyof
    /// </summary>
    [Fact]
    public void Example_092()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Question",
              "name": "What is the answer?",
              "anyOf": [
                {
                  "type": "Note",
                  "name": "Option A"
                },
                {
                  "type": "Note",
                  "name": "Option B"
                }
              ]
            }
            """;

        // Act
        var ex92 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex92.Should().BeAssignableTo<Question>();
        ex92.As<Question>().AnyOf.Should().HaveCount(2);
        ex92.As<Question>().AnyOf.ElementAt(0).As<Note>().Name.First().Should().Be("Option A");
        ex92.As<Question>().AnyOf.ElementAt(1).As<Note>().Name.First().Should().Be("Option B");
    }

    /// <summary>
    /// Example 93 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-closed
    /// </summary>
    [Fact]
    public void Example_093_DateTime()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Question",
              "name": "What is the answer?",
              "closed": "2016-05-10T00:00:00Z"
            }
            """;

        // Act
        var ex93 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex93.Should().BeAssignableTo<Question>();
        ex93.As<Question>().Closed.First().Value.Should().Be(DateTime.Parse("2016-05-10T00:00:00Z", styles: System.Globalization.DateTimeStyles.AdjustToUniversal));
    }

    /// <summary>
    /// Example 93 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-closed
    /// </summary>
    [Fact]
    public void Example_093_boolean_string()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Question",
              "name": "What is the answer?",
              "closed": "true"
            }
            """;

        // Act
        var ex93 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex93.Should().BeAssignableTo<Question>();
        ex93.As<Question>().Closed.First().Value.As<bool>().Should().BeTrue();
    }

    /// <summary>
    /// Example 93 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-closed
    /// </summary>
    [Fact]
    public void Example_093_boolean_string_number()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Question",
              "name": "What is the answer?",
              "closed": "0"
            }
            """;

        // Act
        var ex93 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex93.Should().BeAssignableTo<Question>();
        ex93.As<Question>().Closed.First().Value.As<bool>().Should().BeFalse();
    }

    /// <summary>
    /// Example 93 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-closed
    /// </summary>
    [Fact]
    public void Example_093_boolean()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Question",
              "name": "What is the answer?",
              "closed": true
            }
            """;

        // Act
        var ex93 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex93.Should().BeAssignableTo<Question>();
        ex93.As<Question>().Closed.First().Value.As<bool>().Should().BeTrue();
    }

    /// <summary>
    /// Example 93 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-closed
    /// </summary>
    [Fact]
    public void Example_093_number()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Question",
              "name": "What is the answer?",
              "closed": 1
            }
            """;

        // Act
        var ex93 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex93.Should().BeAssignableTo<Question>();
        ex93.As<Question>().Closed.First().Value.As<bool>().Should().BeTrue();
    }
}

