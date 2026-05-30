<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Mono

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.mono?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.mono/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.mono?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.mono/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams**

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · [QQ Group](https://qm.qq.com/q/5s5e1e6e6e)

**Language**: **English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

---

## Project Overview

Game Frame X Mono is a Mono lifecycle component for the GameFrameX framework. It manages MonoBehaviour events and update cycles in games, such as FixedUpdate, LateUpdate, OnDestroy, etc., and provides a convenient way to add and remove event listeners.

## Quick Start

### Installation

Edit your Unity project's `Packages/manifest.json` and add the `scopedRegistries` section:

```json
{
  "scopedRegistries": [
    {
      "name": "GameFrameX",
      "url": "https://gameframex.upm.alianblank.uk",
      "scopes": [
        "com.gameframex"
      ]
    }
  ],
  "dependencies": {
    "com.gameframex.unity.mono": "1.1.1"
  }
}
```

`scopes` controls which packages are resolved through this registry. Only packages whose names start with `com.gameframex` will be fetched from it.

**Alternative methods:**

1. Add the following to the `dependencies` section in your project's `manifest.json`:
   ```json
   {"com.gameframex.unity.mono": "https://github.com/GameFrameX/com.gameframex.unity.mono.git"}
   ```

2. Use `Git URL` in Unity's Package Manager:
   ```
   https://github.com/GameFrameX/com.gameframex.unity.mono.git
   ```

3. Download the repository and place it in your Unity project's `Packages` directory. It will be loaded automatically.

## Usage

### Getting the Component

```csharp
var monoComponent = GameEntry.GetComponent<MonoComponent>();
```

### Registering Lifecycle Listeners

MonoComponent allows registering callbacks for Unity's `MonoBehaviour` lifecycle events. All listeners can be added or removed at any time.

#### Update / FixedUpdate / LateUpdate

These three listeners receive two `float` parameters:
- `elapseSeconds` — scaled delta time
- `realElapseSeconds` — unscaled delta time

```csharp
private void OnUpdate(float elapseSeconds, float realElapseSeconds)
{
    // Called every frame
}

private void OnFixedUpdate(float elapseSeconds, float realElapseSeconds)
{
    // Called at fixed intervals (physics)
}

private void OnLateUpdate(float elapseSeconds, float realElapseSeconds)
{
    // Called after all Update calls
}

// Register
monoComponent.AddUpdateListener(OnUpdate);
monoComponent.AddFixedUpdateListener(OnFixedUpdate);
monoComponent.AddLateUpdateListener(OnLateUpdate);

// Unregister when no longer needed
monoComponent.RemoveUpdateListener(OnUpdate);
monoComponent.RemoveFixedUpdateListener(OnFixedUpdate);
monoComponent.RemoveLateUpdateListener(OnLateUpdate);
```

#### OnDestroy

```csharp
private void OnDestroyCallback()
{
    // Called when the MonoComponent's GameObject is destroyed
}

monoComponent.AddDestroyListener(OnDestroyCallback);
monoComponent.RemoveDestroyListener(OnDestroyCallback);
```

#### OnApplicationFocus / OnApplicationPause

These listeners receive a `bool` parameter and support a **dual notification pattern** — you can use either direct listeners or the event bus.

**Direct listener approach:**

```csharp
private void OnApplicationFocus(bool isFocus)
{
    // isFocus: true = app gained focus, false = lost focus
}

private void OnApplicationPause(bool isPause)
{
    // isPause: true = app paused, false = resumed
}

monoComponent.AddOnApplicationFocusListener(OnApplicationFocus);
monoComponent.AddOnApplicationPauseListener(OnApplicationPause);

monoComponent.RemoveOnApplicationFocusListener(OnApplicationFocus);
monoComponent.RemoveOnApplicationPauseListener(OnApplicationPause);
```

**Event bus approach** (via `EventComponent`):

```csharp
var eventComponent = GameEntry.GetComponent<EventComponent>();

eventComponent.Subscribe(OnApplicationFocusChangedEventArgs.EventId, OnFocusChanged);
eventComponent.Subscribe(OnApplicationPauseChangedEventArgs.EventId, OnPauseChanged);

private void OnFocusChanged(object sender, GameEventArgs e)
{
    var args = (OnApplicationFocusChangedEventArgs)e;
    if (args.IsFocus)
    {
        // App gained focus
    }
}

private void OnPauseChanged(object sender, GameEventArgs e)
{
    var args = (OnApplicationPauseChangedEventArgs)e;
    if (args.IsPause)
    {
        // App paused
    }
}
```

### Important Notes

- Listener registration is **thread-safe**.
- Listeners can safely add or remove other listeners during callback invocation (snapshot dispatch).
- Exceptions in callbacks are caught and logged, and do **not** interrupt other listeners.
- Always unregister listeners when no longer needed to avoid memory leaks.

## Documentation & Resources

- Documentation: https://gameframex.doc.alianblank.com
- Repository: https://github.com/GameFrameX/com.gameframex.unity.mono
- Issues: https://github.com/GameFrameX/com.gameframex.unity.mono/issues

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE.md) for details.
