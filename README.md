# ActivityStreams
A .NET implementation of the Activity Streams vocabulary in the form of classes that can be serialized using System.Text.Json

The specifications can be seen here: https://www.w3.org/TR/activitystreams-vocabulary/

These types are famously used in the [ActivityPub](https://www.w3.org/TR/activitypub/) specification which is used in the Fediverse including Mastodon.

We have chosen that it should also implement the properties that are specific to ActivityPub as these don't change any of the existing properties and because they are very few.

**This implementation is still being developed, so progress is still very limited.**

## Goals
- [x] Add classes for Core Types.
  - [x] Add class for Object
  - [x] Add class for Link
  - [x] Add class for Activity
  - [x] Add class for IntransitiveActivity
  - [x] Add class for Collection
  - [x] Add class for OrderedCollection
  - [x] Add class for CollectionPage
  - [x] Add class for OrderedCollectionPage
- [x] Add extended classes for Activity Types.
- [x] Add extended classes for Actor Types.
- [x] Add extended classes for Object and Link Types.
- [x] Add properties specific to ActivityPub
- [ ] Add support for retrieving @context JSON-LD defintions.
- [ ] Add support for serializing
- [ ] Look into the [Implementation Notes](https://www.w3.org/TR/activitystreams-vocabulary/#notes) that hint at Ease-Of-Use-Scenarios.
