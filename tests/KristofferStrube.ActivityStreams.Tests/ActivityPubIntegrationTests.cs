using KristofferStrube.ActivityStreams.JsonLD;
using System.Text.Json;

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
        string input = """
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
        IObjectOrLink ex8 = Deserialize<IObjectOrLink>(input);

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
        string input = """
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
        IObjectOrLink ex9 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex9.Should().BeAssignableTo<Person>();
        ex9.As<Person>().Following.Href.Should().Be("https://kenzoishii.example.com/following.json");
        ex9.As<Person>().Followers.Href.Should().Be("https://kenzoishii.example.com/followers.json");
        ex9.As<Person>().Liked.Href.Should().Be("https://kenzoishii.example.com/liked.json");
        ex9.As<Person>().Inbox.Href.Should().Be("https://kenzoishii.example.com/inbox.json");
        ex9.As<Person>().Outbox.Href.Should().Be("https://kenzoishii.example.com/feed.json");
        ex9.As<Person>().PreferredUsername.Should().Be("kenzoishii");
        ex9.As<Person>().Name.First().Should().Be("石井健蔵");
        ex9.As<Person>().Summary.First().Should().Be("この方はただの例です");
        ex9.As<Person>().Icon.First().As<ILink>().Href.Should().Be("https://kenzoishii.example.com/image/165987aklre4");
    }

    /// <summary>
    /// Example 11 taken from https://www.w3.org/TR/activitypub/#client-to-server-interactions
    /// </summary>
    [Fact]
    public void Example_011()
    {
        // Arrange
        string input = """
            {
              "@context": ["https://www.w3.org/ns/activitystreams",
                           {"@language": "en"}],
              "type": "Like",
              "actor": "https://dustycloud.org/chris/",
              "name": "Chris liked 'Minimal ActivityPub update client'",
              "object": "https://rhiaro.co.uk/2016/05/minimal-activitypub",
              "to": ["https://rhiaro.co.uk/#amy",
                     "https://dustycloud.org/followers",
                     "https://rhiaro.co.uk/followers/"],
              "cc": "https://e14n.com/evan"
            }
            """;

        // Act
        IObjectOrLink ex11 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex11.Should().BeAssignableTo<Like>();
        ex11.As<Like>().Actor.First().As<ILink>().Href.Should().Be("https://dustycloud.org/chris/");
        ex11.As<Like>().Name.First().Should().Be("Chris liked 'Minimal ActivityPub update client'");
        ex11.As<Like>().Object.First().As<ILink>().Href.Should().Be("https://rhiaro.co.uk/2016/05/minimal-activitypub");
        ex11.As<Like>().To.Should().HaveCount(3);
        ex11.As<Like>().To.ElementAt(0).As<ILink>().Href.Should().Be("https://rhiaro.co.uk/#amy");
        ex11.As<Like>().To.ElementAt(1).As<ILink>().Href.Should().Be("https://dustycloud.org/followers");
        ex11.As<Like>().To.ElementAt(2).As<ILink>().Href.Should().Be("https://rhiaro.co.uk/followers/");
        ex11.As<Like>().Cc.First().As<ILink>().Href.Should().Be("https://e14n.com/evan");
    }

    [Fact]
    public void Example_Payload_Follow()
    {
        // Arrange
        var followActivity = new Follow()
        {
            Type = ["Follow"],
            JsonLDContext = new List<ReferenceTermDefinition>() { new(new("https://www.w3.org/ns/activitystreams")) },
            Actor = new List<Link>() { new() { Href = new Uri("https://kristoffer-strube.dk/API/AcitivtyPub/Users/Bot") } },
            Target = new List<Link>() { new() { Href = new Uri("https://hachyderm.io/@KristofferStrube") } }
        };

        // Act
        IObjectOrLink payload = Deserialize<IObjectOrLink>(Serialize(followActivity));

        // Assert
        payload.Should().BeAssignableTo<Follow>();
        payload.As<Follow>().Actor.First().As<ILink>().Href.Should().Be("https://kristoffer-strube.dk/API/AcitivtyPub/Users/Bot");
    }

    [Fact]
    public void Example_Payload_WellKnownUser()
    {
        // Arrange
        var person = new Person()
        {
            JsonLDContext = new List<ReferenceTermDefinition>() { new(new("https://www.w3.org/ns/activitystreams")) },
            Id = $"https://kristoffer-strube/API/ActivityPub/Users/Bot",
            PreferredUsername = "Bot",
            Inbox = new Link() { Href = new Uri($"https://kristoffer-strube.dk/API/ActivityPub/Users/Bot/inbox") },
            Type = ["Person"],
            ExtensionData = new()
            {
                { "publicKey", SerializeToElement(
                    new
                    {
                        id = $"https://kristoffer-strube/API/ActivityPub/Users/Bot#main-key",
                        owner = $"https://kristoffer-strube/API/ActivityPub/Users/Bot",
                        publicKeyPem = $"-----BEGIN PUBLIC KEY-----...-----END PUBLIC KEY-----"
                    })
                }
            }
        };

        // Act
        IObjectOrLink payload = Deserialize<IObjectOrLink>(Serialize(person));

        // Assert
        payload.Should().BeAssignableTo<Person>();
        payload.As<Person>().PreferredUsername.Should().Be("Bot");
        payload.As<Person>().Inbox.Href.Should().Be("https://kristoffer-strube.dk/API/ActivityPub/Users/Bot/inbox");
        payload.As<Person>().ExtensionData["publicKey"].Deserialize<Dictionary<string, string>>().Keys.Should().HaveCount(3);
        payload.As<Person>().ExtensionData["publicKey"].Deserialize<Dictionary<string, string>>()["id"].Should().Be($"https://kristoffer-strube/API/ActivityPub/Users/Bot#main-key");
        payload.As<Person>().ExtensionData["publicKey"].Deserialize<Dictionary<string, string>>()["owner"].Should().Be($"https://kristoffer-strube/API/ActivityPub/Users/Bot");
        payload.As<Person>().ExtensionData["publicKey"].Deserialize<Dictionary<string, string>>()["publicKeyPem"].Should().Be($"-----BEGIN PUBLIC KEY-----...-----END PUBLIC KEY-----");
    }

    [Fact]
    public void Example_Payload_Accept()
    {
        // Arrange
        var accept = new Accept()
        {
            Id = $"https://kristoffer-strube.dk/API/ActivityPub/Activity/{Guid.NewGuid()}",
            Object = [new Follow()]
        };

        // Act
        IObjectOrLink payload = Deserialize<IObjectOrLink>(Serialize<IObject>(accept));

        // Assert
        payload.Should().BeAssignableTo<Accept>();
        payload.As<Accept>().Type.Should().Contain("Accept");
        payload.As<Accept>().Object.First().As<Follow>().Type.Should().Contain("Follow");
    }

    [Fact]
    public void Example_Payload_User()
    {
        // Arrange
        var person = new Person()
        {
            JsonLDContext = new List<ReferenceTermDefinition>() { new(new("https://www.w3.org/ns/activitystreams")) },
            Id = $"https://kristoffer-strube.dk/API/ActivityPub/Users/bot",
            Type = ["Person"],
            Endpoints = new Endpoints()
            {
                SharedInbox = new Uri("https://https://hachyderm.io/inbox"),
                ExtensionData = new()
                {
                    { "extraEndpoint", SerializeToElement("https://kristoffer-strube.dk/API/ActivityPub/RealEndpoint") },
                    { "extraValue", SerializeToElement(1) }
                }
            }
        };

        // Act
        IObjectOrLink payload = Deserialize<IObjectOrLink>(Serialize<IObjectOrLink>(person));

        // Assert
        payload.Should().BeAssignableTo<Person>();
        payload.As<Person>().Endpoints.As<Endpoints>().SharedInbox.Should().Be(new Uri("https://https://hachyderm.io/inbox"));
        payload.As<Person>().Endpoints.As<Endpoints>().ExtensionUris.Keys.Should().HaveCount(1);
        payload.As<Person>().Endpoints.As<Endpoints>().ExtensionUris["extraEndpoint"].Should().Be(new Uri("https://kristoffer-strube.dk/API/ActivityPub/RealEndpoint"));
    }
}

