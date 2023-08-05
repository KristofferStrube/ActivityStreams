[![.NET](https://github.com/aluitink/ActivityStreams/actions/workflows/dotnet.yml/badge.svg)](https://github.com/aluitink/ActivityStreams/actions/workflows/dotnet.yml)
[![GitHub issues](https://img.shields.io/github/issues/aluitink/ActivityStreams)](https://github.com/aluitink/ActivityStreams/issues)
[![GitHub forks](https://img.shields.io/github/forks/aluitink/ActivityStreams)](https://github.com/aluitink/ActivityStreams/network/members)
[![GitHub stars](https://img.shields.io/github/stars/aluitink/ActivityStreams)](https://github.com/aluitink/ActivityStreams/stargazers)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](/LICENSE)
[![NuGet Downloads (official NuGet)](https://img.shields.io/nuget/dt/KristofferStrube.ActivityStreams?label=NuGet%20Downloads)](https://www.nuget.org/packages/KristofferStrube.ActivityStreams/)  

# Rayven.ActivityStreams
A custom implementation of KristofferStrube.ActivityStreams for use in a private project.

I've added a .devcontainer, build action, package publishing.
# ActivityStreams
A .NET implementation of the Activity Streams vocabulary in the form of classes that can be serialized/deserialized using System.Text.Json

The specifications can be seen here: https://www.w3.org/TR/activitystreams-vocabulary/

These types are famously used in the [ActivityPub](https://www.w3.org/TR/activitypub/) specification which is used in the Fediverse including Mastodon.

We have chosen that it should also implement the properties that are specific to ActivityPub as these don't change any of the existing properties and because they are very few.

## Features
- Classes for Core Types.
  - Class for Object
  - Class for Link
  - Class for Activity
  - Class for IntransitiveActivity
  - Class for Collection
  - Class for OrderedCollection
  - Class for CollectionPage
  - Class for OrderedCollectionPage
- Extended classes for Activity Types.
- Extended classes for Actor Types.
- Extended classes for Object and Link Types.
- Properties specific to ActivityPub
- Support for retrieving @context JSON-LD defintions.
- Support for serializing

## Related repositories
This is used in the following repositories.
- [KristofferStrube/ActivityPubBotDotNet](https://github.com/KristofferStrube/ActivityPubBotDotNet): An implementation of a ActivityPub bot that can communicate with Mastodon servers.
- [Blazor.FileSystem Search Mastodon Sample](https://kristofferstrube.github.io/Blazor.FileSystem/SearchMastodon): A sample of using the ActivityStreams classes in Blazor to Deserialize the responses from an API.
