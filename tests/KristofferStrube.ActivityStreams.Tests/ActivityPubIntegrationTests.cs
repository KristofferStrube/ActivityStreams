namespace KristofferStrube.ActivityStreams.Tests;

public class ActivityPubIntegrationTests
{
    /// <summary>
    /// Example 8 taken from https://www.w3.org/TR/activitypub/#source-property
    /// </summary>
    [Fact]
    public void Example_008()
    {
        // Arrange
        var input = """
            {
              "@context": ["https://www.w3.org/ns/activitystreams",
                           {"@language": "en"}],
              "type": "Note",
              "id": "http://postparty.example/p/2415",
              "content": "<p>I <em>really</em> like strawberries!</p>",
              "source": {
                "content": "I *really* like strawberries!",
                "mediaType": "text/markdown"}
            }
            """;

        // Act
        var ex8 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex8.Should().BeAssignableTo<Note>();
        ex8.As<Note>().JsonLDContext.Should().HaveCount(2);
        ex8.As<Note>().Id.Should().Be("http://postparty.example/p/2415");
        ex8.As<Note>().Content.First().Should().Be("<p>I <em>really</em> like strawberries!</p>");
        ex8.As<Note>().Source.Content.First().Should().Be("I *really* like strawberries!");
        ex8.As<Note>().Source.MediaType.Should().Be("text/markdown");
    }

    /// <summary>
    /// Example 9 taken from https://www.w3.org/TR/activitypub/#actor-objects
    /// </summary>
    [Fact]
    public void Example_009()
    {
        // Arrange
        var input = """
            {
              "@context": ["https://www.w3.org/ns/activitystreams",
                           {"@language": "ja"}],
              "type": "Person",
              "id": "https://kenzoishii.example.com/",
              "following": "https://kenzoishii.example.com/following.json",
              "followers": "https://kenzoishii.example.com/followers.json",
              "liked": "https://kenzoishii.example.com/liked.json",
              "inbox": "https://kenzoishii.example.com/inbox.json",
              "outbox": "https://kenzoishii.example.com/feed.json",
              "preferredUsername": "kenzoishii",
              "name": "石井健蔵",
              "summary": "この方はただの例です",
              "icon": [
                "https://kenzoishii.example.com/image/165987aklre4"
              ]
            }
            """;

        // Act
        var ex9 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex9.Should().BeAssignableTo<Person>();
        ex9.As<Person>().Following.Href.Should().Be("https://kenzoishii.example.com/following.json");
        ex9.As<Person>().Followers.Href.Should().Be("https://kenzoishii.example.com/followers.json");
        ex9.As<Person>().Liked.Href.Should().Be("https://kenzoishii.example.com/liked.json");
        ex9.As<Person>().Inbox.Href.Should().Be("https://kenzoishii.example.com/inbox.json");
        ex9.As<Person>().Outbox.Href.Should().Be("https://kenzoishii.example.com/feed.json");
    }
}

