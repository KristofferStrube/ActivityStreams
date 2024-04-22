# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [0.2.3] - 2024-04-22
### Fixed
- Fixed that `Question` was changed to be an `Activity` instead of an `IntransitiveActiviy` in `0.2.2`.

## [0.2.2] - 2024-04-08
### Fixed
- Fixed that `IntransitiveActivity` was misspelled as `IntransitiveActiviy` and that it was not derived from `Activity`. By [@deathau](https://github.com/deathau).

## [0.2.1] - 2023-08-13
### Fixed
- Fixed that the converters from the library were internal, meaning they couldn't be used directly in outside projects.

## [0.2.0] - 2023-05-01
### Added
- Added default initialization of `Type` parameters for types matching their type.
- Added default `ReferenceTermDefinition` for `JsonLDContext` of all `ObjectOrLink` objects.
- Enabled XML Documentation generation for NuGet package.
