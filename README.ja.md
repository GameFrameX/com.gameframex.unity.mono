<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X Mono

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.mono?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.mono/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.mono?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.mono/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援**

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · [QQグループ](https://qm.qq.com/q/5s5e1e6e6e)

**言語**: [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

---

## プロジェクト概要

Game Frame X Mono は、GameFrameX フレームワークの Mono ライフサイクルコンポーネントです。FixedUpdate、LateUpdate、OnDestroy などの MonoBehaviour イベントと更新サイクルを管理し、これらのイベントリスナーを簡単に追加・削除する方法を提供します。

## クイックスタート

### インストール

以下のいずれかの方法をお選びください：

1. プロジェクトの `manifest.json` の `dependencies` セクションに以下を追加：
   ```json
   {"com.gameframex.unity.mono": "https://github.com/AlianBlank/com.gameframex.unity.mono.git"}
   ```

2. Unity の Package Manager で `Git URL` を使用：
   ```
   https://github.com/AlianBlank/com.gameframex.unity.mono.git
   ```

3. リポジトリをダウンロードして Unity プロジェクトの `Packages` ディレクトリに配置。自動的にロードされます。

## 使用例

```csharp
// Mono コンポーネントの取得
var monoComponent = GameEntry.GetComponent<MonoComponent>();

// FixedUpdate リスナーの追加
monoComponent.AddFixedUpdateListener(MyFixedUpdate);

// LateUpdate リスナーの追加
monoComponent.AddLateUpdateListener(MyLateUpdate);

// OnDestroy リスナーの追加
monoComponent.AddDestroyListener(MyOnDestroy);

// OnApplicationFocus リスナーの追加
monoComponent.AddOnApplicationFocusListener(MyOnApplicationFocus);

// OnApplicationPause リスナーの追加
monoComponent.AddOnApplicationPauseListener(MyOnApplicationPause);

// リスナーの削除
monoComponent.RemoveFixedUpdateListener(MyFixedUpdate);
monoComponent.RemoveLateUpdateListener(MyLateUpdate);
monoComponent.RemoveDestroyListener(MyOnDestroy);
```

## ドキュメントとリソース

- ドキュメント: https://gameframex.doc.alianblank.com
- リポジトリ: https://github.com/GameFrameX/com.gameframex.unity.mono
- Issues: https://github.com/GameFrameX/com.gameframex.unity.mono/issues

## ライセンス

このプロジェクトは MIT ライセンスの下で公開されています。詳細は [LICENSE](LICENSE.md) ファイルを参照してください。
