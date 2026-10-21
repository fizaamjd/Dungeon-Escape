# Dungeon-Escape

A Unity dungeon prototype with player movement, enemy pursuit, key collection, destination triggers, and a countdown timer.

**Status:** archived coursework, documented and organized for source review. **Engine:** Unity 2022.3.47f1 / C#.

## What is implemented

- WASD or arrow-key movement across the XZ plane.
- Enemy pursuit, key collection and destination collision handlers.
- A 60-second countdown with an on-screen time label.
- Historical prototype limitations: the timeout displays a message, and collision win/lose logic pauses the scene rather than using a finished end-state menu.

## Native build

A [macOS build helper and commands](docs/MAC_BUILD.md) are available. They require the complete original assets and Unity 2022.3.47f1. A successful native build and gameplay recording are still pending.

## Run and inspect

Read [asset setup](docs/ASSET_SETUP.md) before opening Unity. This is an authored-source archive; imported artwork must be restored separately. Build scenes are retained in `ProjectSettings/EditorBuildSettings.asset`.

## Source map

| Path | Purpose |
| --- | --- |
| `Assets/*.cs` | Gameplay and UI behaviors |
| `Assets/All Scenes` or `Assets/Scenes` | Authored scene serialization |
| `Packages` | Unity package versions |
| `ProjectSettings` | Editor version, input mapping and build-scene order |
| `docs/asset-manifest.json` | Asset paths, sizes and hashes for restoration |

## Verification

Repository checks validate the package manifest, editor version, scene references and source inventory. Unity and the Windows runtime are not installed on the maintenance host, so an editor build or playthrough is not claimed. See asset setup for the required local validation.

## Project maintenance

[Contributing](CONTRIBUTING.md) · [Security](SECURITY.md) · [Third-party notices](THIRD_PARTY_NOTICES.md)

MIT covers original code and documentation only. Original source folder: `GD_Mid`. No second copy of this project is published under another repository name.
