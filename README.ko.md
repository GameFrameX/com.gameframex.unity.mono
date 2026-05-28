<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Mono

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.mono?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.mono/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.mono?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.mono/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현**

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · [QQ 그룹](https://qm.qq.com/q/5s5e1e6e6e)

**언어**: [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

---

## 프로젝트 개요

Game Frame X Mono는 GameFrameX 프레임워크의 Mono 수명 주기 컴포넌트입니다. FixedUpdate, LateUpdate, OnDestroy 등 MonoBehaviour 이벤트와 업데이트 주기를 관리하며, 이벤트 리스너를 간편하게 추가하고 제거하는 방법을 제공합니다.

## 빠른 시작

### 설치

Unity 프로젝트의 `Packages/manifest.json`을 편집하여 `scopedRegistries` 섹션을 추가하세요:

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

`scopes`는 이 레지스트리를 통해 어떤 패키지를 해석할지 제어합니다. `com.gameframex`로 시작하는 패키지만 이 레지스트리에서 가져옵니다.

**다른 설치 방법:**

1. 프로젝트의 `manifest.json` 파일의 `dependencies` 섹션에 다음을 추가:
   ```json
   {"com.gameframex.unity.mono": "https://github.com/AlianBlank/com.gameframex.unity.mono.git"}
   ```

2. Unity의 Package Manager에서 `Git URL` 사용:
   ```
   https://github.com/AlianBlank/com.gameframex.unity.mono.git
   ```

3. 저장소를 다운로드하여 Unity 프로젝트의 `Packages` 디렉토리에 배치. 자동으로 로드됩니다.

## 사용 예시

```csharp
// Mono 컴포넌트 가져오기
var monoComponent = GameEntry.GetComponent<MonoComponent>();

// FixedUpdate 리스너 추가
monoComponent.AddFixedUpdateListener(MyFixedUpdate);

// LateUpdate 리스너 추가
monoComponent.AddLateUpdateListener(MyLateUpdate);

// OnDestroy 리스너 추가
monoComponent.AddDestroyListener(MyOnDestroy);

// OnApplicationFocus 리스너 추가
monoComponent.AddOnApplicationFocusListener(MyOnApplicationFocus);

// OnApplicationPause 리스너 추가
monoComponent.AddOnApplicationPauseListener(MyOnApplicationPause);

// 리스너 제거
monoComponent.RemoveFixedUpdateListener(MyFixedUpdate);
monoComponent.RemoveLateUpdateListener(MyLateUpdate);
monoComponent.RemoveDestroyListener(MyOnDestroy);
```

## 문서 및 자료

- 문서: https://gameframex.doc.alianblank.com
- 저장소: https://github.com/GameFrameX/com.gameframex.unity.mono
- Issues: https://github.com/GameFrameX/com.gameframex.unity.mono/issues

## 라이선스

이 프로젝트는 MIT 라이선스에 따라 배포됩니다. 자세한 내용은 [LICENSE](LICENSE.md) 파일을 참조하세요.
