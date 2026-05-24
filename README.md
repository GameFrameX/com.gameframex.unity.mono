<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X Mono

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.mono?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.mono/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.mono?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.mono/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams**

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · [QQ Group](https://qm.qq.com/q/5s5e1e6e6e)

**Language**: **English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## Project Overview

Game Frame X Mono is a Mono lifecycle component for the GameFrameX framework. It manages MonoBehaviour events and update cycles in games, such as FixedUpdate, LateUpdate, OnDestroy, etc., and provides a convenient way to add and remove event listeners.

## Quick Start

### Installation

Choose one of the following methods:

1. Add the following to the `dependencies` section in your project's `manifest.json`:
   ```json
   {"com.gameframex.unity.mono": "https://github.com/AlianBlank/com.gameframex.unity.mono.git"}
   ```

2. Use `Git URL` in Unity's Package Manager:
   ```
   https://github.com/AlianBlank/com.gameframex.unity.mono.git
   ```

3. Download the repository and place it in your Unity project's `Packages` directory. It will be loaded automatically.

## Usage Examples

```csharp
// Get Mono component
var monoComponent = GameEntry.GetComponent<MonoComponent>();

// Add FixedUpdate listener
monoComponent.AddFixedUpdateListener(MyFixedUpdate);

// Add LateUpdate listener
monoComponent.AddLateUpdateListener(MyLateUpdate);

// Add OnDestroy listener
monoComponent.AddDestroyListener(MyOnDestroy);

// Add OnApplicationFocus listener
monoComponent.AddOnApplicationFocusListener(MyOnApplicationFocus);

// Add OnApplicationPause listener
monoComponent.AddOnApplicationPauseListener(MyOnApplicationPause);

// Remove listeners
monoComponent.RemoveFixedUpdateListener(MyFixedUpdate);
monoComponent.RemoveLateUpdateListener(MyLateUpdate);
monoComponent.RemoveDestroyListener(MyOnDestroy);
```

## Documentation & Resources

- Documentation: https://gameframex.doc.alianblank.com
- Repository: https://github.com/GameFrameX/com.gameframex.unity.mono
- Issues: https://github.com/GameFrameX/com.gameframex.unity.mono/issues

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE.md) for details.
