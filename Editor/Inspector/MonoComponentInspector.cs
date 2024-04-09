//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFrameX.Editor;
using GameFrameX.Mono.Runtime;
using UnityEditor;

namespace GameFrameX.Mono.Editor
{
    [CustomEditor(typeof(MonoComponent))]
    internal sealed class MonoComponentInspector : GameFrameworkInspector
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            /*
            if (!EditorApplication.isPlaying)
            {
                EditorGUILayout.HelpBox("Available during runtime only.", MessageType.Info);
                return;
            }

            var t = (FsmComponent)target;

            if (IsPrefabInHierarchy(t.gameObject))
            {
                EditorGUILayout.LabelField("FSM Count", t.Count.ToString());

                var fsms = t.GetAllFsmList();
                foreach (FsmBase fsm in fsms)
                {
                    DrawFsm(fsm);
                }
            }*/

            Repaint();
        }

        private void OnEnable()
        {
        }
    }
}