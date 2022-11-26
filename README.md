# ActivityStreams
A .NET implementation of the Activity Streams vocabulary in the form of classes that can be serialized using System.Text.Json

The specifications can be seen here: https://www.w3.org/TR/activitystreams-vocabulary/

These types are famously used in the [ActivityPub](https://www.w3.org/TR/activitypub/) specification which is used in the Fediverse including Mastodon.

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
- [ ] Add extended classes for Activity Types.
- [ ] Add extended classes for Actor Types.
- [ ] Add extended classes for Object and Link Types.
- [ ] Add support for retrieving @context JSON-LD defintions.
- [ ] Add support for serializing
- [ ] Look into the [Implementation Notes](https://www.w3.org/TR/activitystreams-vocabulary/#notes) that hint at Ease-Of-Use-Scenarios.
