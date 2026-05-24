<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X Mono

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.mono?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.mono/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.mono?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.mono/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使**

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · [QQ群](https://qm.qq.com/q/5s5e1e6e6e)

**语言**: [English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## 项目简介

Game Frame X Mono 是 GameFrameX 框架的 Mono 生命周期组件，用于管理游戏中 MonoBehaviour 的事件和更新周期，例如 FixedUpdate、LateUpdate、OnDestroy 等，并提供了一种简便的方式来添加和移除这些事件的监听。

## 快速开始

### 安装

任选以下方式之一：

1. 直接在 `manifest.json` 的文件中的 `dependencies` 节点下添加以下内容：
   ```json
   {"com.gameframex.unity.mono": "https://github.com/AlianBlank/com.gameframex.unity.mono.git"}
   ```

2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式添加库，地址为：
   ```
   https://github.com/AlianBlank/com.gameframex.unity.mono.git
   ```

3. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下，会自动加载识别。

## 使用示例

```csharp
// 获取 Mono 组件
var monoComponent = GameEntry.GetComponent<MonoComponent>();

// 添加 FixedUpdate 监听
monoComponent.AddFixedUpdateListener(MyFixedUpdate);

// 添加 LateUpdate 监听
monoComponent.AddLateUpdateListener(MyLateUpdate);

// 添加 OnDestroy 监听
monoComponent.AddDestroyListener(MyOnDestroy);

// 添加 OnApplicationFocus 监听
monoComponent.AddOnApplicationFocusListener(MyOnApplicationFocus);

// 添加 OnApplicationPause 监听
monoComponent.AddOnApplicationPauseListener(MyOnApplicationPause);

// 移除监听
monoComponent.RemoveFixedUpdateListener(MyFixedUpdate);
monoComponent.RemoveLateUpdateListener(MyLateUpdate);
monoComponent.RemoveDestroyListener(MyOnDestroy);
```

## 文档与资源

- 文档地址: https://gameframex.doc.alianblank.com
- 仓库地址: https://github.com/GameFrameX/com.gameframex.unity.mono
- 问题反馈: https://github.com/GameFrameX/com.gameframex.unity.mono/issues

## 开源协议

本项目遵循 MIT 许可证。详细信息请查看 [LICENSE](LICENSE.md) 文件。
