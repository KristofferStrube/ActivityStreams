# ActivityStreams
A .NET implementation of the Activity Streams vocabulary in the form of classes that can be serialized using System.Text.Json

The specifications can be seen here: https://www.w3.org/TR/activitystreams-vocabulary/

These types are famously used in the [ActivityPub](https://www.w3.org/TR/activitypub/) specification which is used in the Fediverse inclusing Mastodon.

**This implementation is still being developed, so progress is still very limited.**

## Goals
- [ ] Add classes for Core Types.
  - [x] Add class for Object
  - [x] Add class for Link
  - [ ] Add class for Activity
  - [ ] Add class for IntransitiveActivity
  - [ ] Add class for Collection
  - [ ] Add class for OrderedCollection
  - [ ] Add class for CollectionPage
  - [ ] Add class for OrderedCollectionPage
- [ ] Add extended classes for Activity Types.
- [ ] Add extended classes for Actor Types.
- [ ] Add extended classes for Object and Link Types.
- [ ] Add support for deserializing/serializing and using @context JSON-LD attribute.
- [ ] Look into the [Implementation Notes](https://www.w3.org/TR/activitystreams-vocabulary/#notes) that hint at Ease-Of-Use-Scenarios.
