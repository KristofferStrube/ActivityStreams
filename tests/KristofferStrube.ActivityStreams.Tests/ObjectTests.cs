namespace KristofferStrube.ActivityStreams.Tests;

public class ObjectTests
{
    [Fact]
    /// <remarks>Example 1 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-object</remarks>
    public void Example_001()
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
        var ex1 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex1.Should().BeAssignableTo<Object>();
        ex1.As<Object>().JsonLDContext.Should().Be(new Uri("https://www.w3.org/ns/activitystreams"));
        ex1.As<Object>().Id.Should().Be("http://www.test.example/object/1");
        ex1.As<Object>().Name.First().Should().Be("A Simple, non-specific object");
    }

    [Fact]
    /// <remarks>Example 61 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-id</remarks>
    public void Example_061()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "name": "Foo",
              "id": "http://example.org/foo"
            }
            """;

        // Act
        var ex61 = Deserialize<ObjectOrLink>(input);

        // Assert
        ex61.Id.Should().Be("http://example.org/foo");
        ex61.IdAsUri.Should().Be(new Uri("http://example.org/foo"));
    }

    [Fact]
    /// <remarks>Example 62 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-type</remarks>
    public void Example_062()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A foo",
              "type": "http://example.org/Foo"
            }
            """;

        // Act
        var ex62 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex62.Type.Should().Be("http://example.org/Foo");
    }

    [Fact]
    /// <remarks>Example 66 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-attachment</remarks>
    public void Example_066()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Note",
              "name": "Have you seen my cat?",
              "attachment": [
                {
                  "type": "Image",
                  "content": "This is what he looks like.",
                  "url": "http://example.org/cat.jpeg"
                }
              ]
            }
            """;

        // Act
        var ex66 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex66.Should().BeAssignableTo<Note>();
        ex66.As<Note>().Attachment.Should().HaveCount(1);
        ex66.As<Note>().Attachment.First().Should().BeAssignableTo<Image>();
        ex66.As<Note>().Attachment.First().As<Image>().Content.First().Should().Be("This is what he looks like.");
    }

    [Fact]
    /// <remarks>Example 67 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-attributedto</remarks>
    public void Example_067()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Image",
              "name": "My cat taking a nap",
              "url": "http://example.org/cat.jpeg",
              "attributedTo": [
                {
                  "type": "Person",
                  "name": "Sally"
                }
              ]
            }
            """;

        // Act
        var ex67 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex67.Should().BeAssignableTo<Image>();
        ex67.As<Image>().AttributedTo.Should().HaveCount(1);
        ex67.As<Image>().AttributedTo.First().Should().BeAssignableTo<Person>();
        ex67.As<Image>().AttributedTo.First().As<Person>().Name.First().Should().Be("Sally");
    }

    [Fact]
    /// <remarks>Example 68 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-attributedto</remarks>
    public void Example_068()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Image",
              "name": "My cat taking a nap",
              "url": "http://example.org/cat.jpeg",
              "attributedTo": [
                "http://joe.example.org",
                {
                  "type": "Person",
                  "name": "Sally"
                }
              ]
            }
            """;

        // Act
        var ex68 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex68.Should().BeAssignableTo<Image>();
        ex68.As<Image>().AttributedTo.Should().HaveCount(2);
        ex68.As<Image>().AttributedTo.ElementAt(0).Should().BeAssignableTo<Link>();
        ex68.As<Image>().AttributedTo.ElementAt(0).As<Link>().Href.Should().Be(new Uri("http://joe.example.org"));
        ex68.As<Image>().AttributedTo.ElementAt(1).Should().BeAssignableTo<Object>();
        ex68.As<Image>().AttributedTo.ElementAt(1).As<Object>().Name.First().Should().Be("Sally");
    }

    [Fact]
    /// <remarks>Example 69 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-audience</remarks>
    public void Example_069()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "name": "Holiday announcement",
              "type": "Note",
              "content": "Thursday will be a company-wide holiday. Enjoy your day off!",
              "audience": {
                "type": "http://example.org/Organization",
                "name": "ExampleCo LLC"
              }
            }
            """;

        // Act
        var ex69 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex69.Should().BeAssignableTo<Note>();
        ex69.As<Note>().Audience.Should().HaveCount(1);
        ex69.As<Note>().Audience.First().Type.Should().Be("http://example.org/Organization");
    }

    [Fact]
    /// <remarks>Example 70 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-bcc</remarks>
    public void Example_070()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally offered a post to John",
              "type": "Offer",
              "actor": "http://sally.example.org",
              "object": "http://example.org/posts/1",
              "target": "http://john.example.org",
              "bcc": [ "http://joe.example.org" ]
            }
            """;

        // Act
        var ex70 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex70.Should().BeAssignableTo<Offer>();
        ex70.As<Offer>().Bcc.Should().HaveCount(1);
        ex70.As<Offer>().Bcc.First().Should().BeAssignableTo<Link>();
        ex70.As<Offer>().Bcc.First().As<Link>().Href.Should().Be(new Uri("http://joe.example.org"));
    }

    [Fact]
    /// <remarks>Example 71 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-bto</remarks>
    public void Example_071()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally offered a post to John",
              "type": "Offer",
              "actor": "http://sally.example.org",
              "object": "http://example.org/posts/1",
              "target": "http://john.example.org",
              "bto": [ "http://joe.example.org" ]
            }
            """;

        // Act
        var ex71 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex71.Should().BeAssignableTo<Offer>();
        ex71.As<Offer>().Bto.Should().HaveCount(1);
        ex71.As<Offer>().Bto.First().Should().BeAssignableTo<Link>();
        ex71.As<Offer>().Bto.First().As<Link>().Href.Should().Be(new Uri("http://joe.example.org"));
    }

    [Fact]
    /// <remarks>Example 72 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-cc</remarks>
    public void Example_072()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally offered a post to John",
              "type": "Offer",
              "actor": "http://sally.example.org",
              "object": "http://example.org/posts/1",
              "target": "http://john.example.org",
              "cc": [ "http://joe.example.org" ]
            }
            """;

        // Act
        var ex72 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex72.Should().BeAssignableTo<Offer>();
        ex72.As<Offer>().Cc.Should().HaveCount(1);
        ex72.As<Offer>().Cc.First().Should().BeAssignableTo<Link>();
        ex72.As<Offer>().Cc.First().As<Link>().Href.Should().Be(new Uri("http://joe.example.org"));
    }

    [Fact]
    /// <remarks>Example 73 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-context</remarks>
    public void Example_073()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Activities in context 1",
              "type": "Collection",
              "items": [
                {
                  "type": "Offer",
                  "actor": "http://sally.example.org",
                  "object": "http://example.org/posts/1",
                  "target": "http://john.example.org",
                  "context": "http://example.org/contexts/1"
                },
                {
                  "type": "Like",
                  "actor": "http://joe.example.org",
                  "object": "http://example.org/posts/2",
                  "context": "http://example.org/contexts/1"
                }
              ]
            }
            """;

        // Act
        var ex73 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex73.Should().BeAssignableTo<Collection>();
        ex73.As<Collection>().Items.First().As<Offer>().Context.First().As<Link>().Href.Should().Be("http://example.org/contexts/1");
        ex73.As<Collection>().Items.Last().As<Like>().Context.First().As<Link>().Href.Should().Be("http://example.org/contexts/1");
    }

    [Fact]
    /// <remarks>Example 78 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-generator</remarks>
    public void Example_078()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A simple note",
              "type": "Note",
              "content": "This is all there is.",
              "generator": {
                "type": "Application",
                "name": "Exampletron 3000"
              }
            }
            """;

        // Act
        var ex78 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex78.Should().BeAssignableTo<Note>();
        ex78.As<Note>().Generator.Should().HaveCount(1);
        ex78.As<Note>().Generator.First().Should().BeAssignableTo<Application>();
        ex78.As<Note>().Generator.First().As<Application>().Name.First().Should().Be("Exampletron 3000");
    }

    [Fact]
    /// <remarks>Example 79 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-icon</remarks>
    public void Example_079()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A simple note",
              "type": "Note",
              "content": "This is all there is.",
              "icon": {
                "type": "Image",
                "name": "Note icon",
                "url": "http://example.org/note.png",
                "width": 16,
                "height": 16
              }
            }
            """;

        // Act
        var ex79 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex79.Should().BeAssignableTo<Note>();
        ex79.As<Note>().Icon.Should().HaveCount(1);
        ex79.As<Note>().Icon.First().Should().BeAssignableTo<Image>();
        ex79.As<Note>().Icon.First().As<Image>().Name.First().Should().Be("Note icon");
    }

    [Fact]
    /// <remarks>Example 80 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-icon</remarks>
    public void Example_080()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A simple note",
              "type": "Note",
              "content": "A simple note",
              "icon": [
                {
                  "type": "Image",
                  "summary": "Note (16x16)",
                  "url": "http://example.org/note1.png",
                  "width": 16,
                  "height": 16
                },
                {
                  "type": "Image",
                  "summary": "Note (32x32)",
                  "url": "http://example.org/note2.png",
                  "width": 32,
                  "height": 32
                }
              ]
            }
            """;

        // Act
        var ex80 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex80.Should().BeAssignableTo<Note>();
        ex80.As<Note>().Icon.Should().HaveCount(2);
        ex80.As<Note>().Icon.First().Should().BeAssignableTo<Image>();
        ex80.As<Note>().Icon.First().As<Image>().Summary.First().Should().Be("Note (16x16)");
        ex80.As<Note>().Icon.Last().As<Image>().Summary.First().Should().Be("Note (32x32)");
    }

    [Fact]
    /// <remarks>Example 81 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-image</remarks>
    public void Example_081()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "name": "A simple note",
              "type": "Note",
              "content": "This is all there is.",
              "image": {
                "type": "Image",
                "name": "A Cat",
                "url": "http://example.org/cat.png"
              }
            }
            """;

        // Act
        var ex81 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex81.Should().BeAssignableTo<Note>();
        ex81.As<Note>().Image.Should().HaveCount(1);
        ex81.As<Note>().Image.First().Should().BeAssignableTo<Image>();
        ex81.As<Note>().Image.First().As<Image>().Name.First().Should().Be("A Cat");
    }

    [Fact]
    /// <remarks>Example 82 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-image</remarks>
    public void Example_082()
    {
        // Arrange
        // We changed the second element in the below image list to be a url to validate that that is possible.
        // We also added an explicit Link after that.
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "name": "A simple note",
              "type": "Note",
              "content": "This is all there is.",
              "image": [
                {
                  "type": "Image",
                  "name": "Cat 1",
                  "url": "http://example.org/cat1.png"
                },
                "http://example.org/cat2.png",
                {
                  "type": "Link",
                  "href": "http://example.org/cat3.png"
                }
              ]
            }
            """;

        // Act
        var ex82 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex82.Should().BeAssignableTo<Note>();
        ex82.As<Note>().Image.Should().HaveCount(3);
        ex82.As<Note>().Image.ElementAt(0).Should().BeAssignableTo<Image>();
        ex82.As<Note>().Image.ElementAt(0).As<Image>().Name.First().Should().Be("Cat 1");
        ex82.As<Note>().Image.ElementAt(1).Should().BeAssignableTo<ILink>();
        ex82.As<Note>().Image.ElementAt(1).As<ILink>().Href.Should().Be(new Uri("http://example.org/cat2.png"));
        ex82.As<Note>().Image.ElementAt(2).Should().BeAssignableTo<ILink>();
        ex82.As<Note>().Image.ElementAt(2).As<ILink>().Href.Should().Be(new Uri("http://example.org/cat3.png"));
    }

    [Fact]
    /// <remarks>Example 83 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-inreplyto</remarks>
    public void Example_083()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A simple note",
              "type": "Note",
              "content": "This is all there is.",
              "inReplyTo": {
                "summary": "Previous note",
                "type": "Note",
                "content": "What else is there?"
              }
            }
            """;

        // Act
        var ex83 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex83.Should().BeAssignableTo<Note>();
        ex83.As<Note>().InReplyTo.Should().HaveCount(1);
        ex83.As<Note>().InReplyTo.First().As<Note>().Content.First().Should().Be("What else is there?");
    }

    [Fact]
    /// <remarks>Example 84 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-inreplyto</remarks>
    public void Example_084()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A simple note",
              "type": "Note",
              "content": "This is all there is.",
              "inReplyTo": "http://example.org/posts/1"
            }
            """;

        // Act
        var ex84 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex84.Should().BeAssignableTo<Note>();
        ex84.As<Note>().InReplyTo.Should().HaveCount(1);
        ex84.As<Note>().InReplyTo.First().As<Link>().Href.Should().Be("http://example.org/posts/1");
    }

    [Fact]
    /// <remarks>Example 88 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-location</remarks>
    public void Example_088()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Person",
              "name": "Sally",
              "location": {
                "name": "Over the Arabian Sea, east of Socotra Island Nature Sanctuary",
                "type": "Place",
                "longitude": 12.34,
                "latitude": 56.78,
                "altitude": 90,
                "units": "m"
              }
            }
            """;

        // Act
        var ex88 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex88.Should().BeAssignableTo<Person>();
        ex88.As<Person>().Location.Should().HaveCount(1);
        ex88.As<Person>().Location.First().As<Place>().Name.First().Should().Be("Over the Arabian Sea, east of Socotra Island Nature Sanctuary");
    }

    [Fact]
    /// <remarks>Example 89 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-items</remarks>
    public void Example_089()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally's notes",
              "type": "Collection",
              "totalItems": 2,
              "items": [
                {
                  "type": "Note",
                  "name": "Reminder for Going-Away Party"
                },
                {
                  "type": "Note",
                  "name": "Meeting 2016-11-17"
                }
              ]
            }
            """;

        // Act
        var ex89 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex89.Should().BeAssignableTo<Collection>();
        ex89.As<Collection>().Items.Should().HaveCount(2);
        ex89.As<Collection>().Items.First().As<Note>().Name.First().Should().Be("Reminder for Going-Away Party");
        ex89.As<Collection>().Items.Last().As<Note>().Name.First().Should().Be("Meeting 2016-11-17");
    }

    [Fact]
    /// <remarks>Example 90 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-items</remarks>
    public void Example_090()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "Sally's notes",
              "type": "OrderedCollection",
              "totalItems": 2,
              "orderedItems": [
                {
                  "type": "Note",
                  "name": "Meeting 2016-11-17"
                },
                {
                  "type": "Note",
                  "name": "Reminder for Going-Away Party"
                }
              ]
            }
            """;

        // Act
        var ex90 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex90.Should().BeAssignableTo<OrderedCollection>();
        ex90.As<OrderedCollection>().OrderedItems.Should().HaveCount(2);
        ex90.As<OrderedCollection>().OrderedItems.First().As<Note>().Name.First().Should().Be("Meeting 2016-11-17");
        ex90.As<OrderedCollection>().OrderedItems.Last().As<Note>().Name.First().Should().Be("Reminder for Going-Away Party");
    }

    [Fact]
    /// <remarks>Example 102 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-preview</remarks>
    public void Example_102()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Video",
              "name": "Cool New Movie",
              "duration": "PT2H30M",
              "preview": {
                "type": "Video",
                "name": "Trailer",
                "duration": "PT1M",
                "url": {
                  "href": "http://example.org/trailer.mkv",
                  "mediaType": "video/mkv"
                }
              }
            }
            """;

        // Act
        var ex102 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex102.Should().BeAssignableTo<Video>();
        ex102.As<Video>().Preview.Should().HaveCount(1);
        ex102.As<Video>().Preview.First().As<Video>().Name.First().Should().Be("Trailer");
    }

    [Fact]
    /// <remarks>Example 104 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-replies</remarks>
    public void Example_104()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "summary": "A simple note",
              "type": "Note",
              "id": "http://www.test.example/notes/1",
              "content": "I am fine.",
              "replies": {
                "type": "Collection",
                "totalItems": 1,
                "items": [
                  {
                    "summary": "A response to the note",
                    "type": "Note",
                    "content": "I am glad to hear it.",
                    "inReplyTo": "http://www.test.example/notes/1"
                  }
                ]
              }
            }
            """;

        // Act
        var ex104 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex104.Should().BeAssignableTo<Note>();
        ex104.As<Note>().Replies.As<Collection>().Items.First().As<Note>().Content.First().Should().Be("I am glad to hear it.");
    }

    [Fact]
    /// <remarks>Example 105 taken from https://www.w3.org/TR/activitystreams-vocabulary/#dfn-tag</remarks>
    public void Example_105()
    {
        // Arrange
        var input = """
            {
              "@context": "https://www.w3.org/ns/activitystreams",
              "type": "Image",
              "summary": "Picture of Sally",
              "url": "http://example.org/sally.jpg",
              "tag": [
                {
                  "type": "Person",
                  "id": "http://sally.example.org",
                  "name": "Sally"
                }
              ]
            }
            """;

        // Act
        var ex105 = Deserialize<IObjectOrLink>(input);

        // Assert
        ex105.Should().BeAssignableTo<Image>();
        ex105.As<Image>().Tag.Should().HaveCount(1);
        ex105.As<Image>().Tag.First().As<Person>().Name.First().Should().Be("Sally");
    }
}

