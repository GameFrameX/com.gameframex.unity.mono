<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Mono

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.mono?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.mono/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.mono?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.mono/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使**

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · [QQ群](https://qm.qq.com/q/5s5e1e6e6e)

**語言**: [English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

---

## 項目簡介

Game Frame X Mono 是 GameFrameX 框架的 Mono 生命週期組件，用於管理遊戲中 MonoBehaviour 的事件和更新週期，例如 FixedUpdate、LateUpdate、OnDestroy 等，並提供了一種簡便的方式來添加和移除這些事件的監聽。

## 快速開始

### 安裝

編輯 Unity 專案的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

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

`scopes` 控制哪些套件透過此註冊表解析。只有以 `com.gameframex` 開頭的套件才會從這個註冊表取得。

**其他安裝方式：**

1. 直接在 `manifest.json` 的 `dependencies` 節點下添加以下內容：
   ```json
   {"com.gameframex.unity.mono": "https://github.com/AlianBlank/com.gameframex.unity.mono.git"}
   ```

2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式添加庫，地址為：
   ```
   https://github.com/AlianBlank/com.gameframex.unity.mono.git
   ```

3. 直接下載倉庫放置到 Unity 專案的 `Packages` 目錄下，會自動加載識別。

## 使用範例

```csharp
// 獲取 Mono 組件
var monoComponent = GameEntry.GetComponent<MonoComponent>();

// 添加 FixedUpdate 監聽
monoComponent.AddFixedUpdateListener(MyFixedUpdate);

// 添加 LateUpdate 監聽
monoComponent.AddLateUpdateListener(MyLateUpdate);

// 添加 OnDestroy 監聽
monoComponent.AddDestroyListener(MyOnDestroy);

// 添加 OnApplicationFocus 監聽
monoComponent.AddOnApplicationFocusListener(MyOnApplicationFocus);

// 添加 OnApplicationPause 監聽
monoComponent.AddOnApplicationPauseListener(MyOnApplicationPause);

// 移除監聽
monoComponent.RemoveFixedUpdateListener(MyFixedUpdate);
monoComponent.RemoveLateUpdateListener(MyLateUpdate);
monoComponent.RemoveDestroyListener(MyOnDestroy);
```

## 文檔與資源

- 文檔地址: https://gameframex.doc.alianblank.com
- 倉庫地址: https://github.com/GameFrameX/com.gameframex.unity.mono
- 問題反饋: https://github.com/GameFrameX/com.gameframex.unity.mono/issues

## 開源協議

本項目遵循 MIT 許可證。詳細信息請查看 [LICENSE](LICENSE.md) 文件。
