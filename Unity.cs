using UnityEngine;
using UnityEditor;
using System.Threading.Tasks;

namespace NexusCore.Engine
{
    public class NexusCoreOrigin : EditorWindow
    {
        private string gamePrompt = "AAA+ Realistic Survival, High Fidelity Environment";
        private bool isGenerating = false;
        private float progress = 0f;

        [MenuItem("Nexus Core/Launch Engine")]
        public static void ShowWindow() => GetWindow<NexusCoreOrigin>("Nexus Core Engine");

        void OnGUI()
        {
            // Minimalist Dark Professional UI
            var headerStyle = new GUIStyle(EditorStyles.label) { 
                fontSize = 18, 
                fontStyle = FontStyle.Bold,
                normal = { textColor = new Color(0.9f, 0.9f, 0.9f) } 
            };

            EditorGUILayout.BeginVertical(new GUIStyle { padding = new RectOffset(20, 20, 20, 20) });
            
            GUILayout.Label("NEXUS CORE ENGINE", headerStyle);
            GUILayout.Label("Autonomous Procedural Architect", EditorStyles.miniLabel);
            
            GUILayout.Space(20);

            EditorGUILayout.LabelField("Architectural Blueprint (Prompt)", EditorStyles.boldLabel);
            gamePrompt = EditorGUILayout.TextArea(gamePrompt, GUILayout.Height(80));

            GUILayout.Space(20);

            if (isGenerating)
            {
                Rect r = EditorGUILayout.GetControlRect(false, 3);
                EditorGUI.ProgressBar(r, progress, "");
                Repaint();
            }
            else
            {
                if (GUILayout.Button("SYNTHESIZE UNIVERSE", GUILayout.Height(40)))
                {
                    _ = InitiateSynthesis();
                }
            }

            EditorGUILayout.EndVertical();
        }

        async Task InitiateSynthesis()
        {
            isGenerating = true;
            // Logical flow: Vanguard -> Synthesis -> Injection
            progress = 0.1f; await Task.Delay(500);
            progress = 0.4f; await Task.Delay(1000);
            progress = 0.7f; await Task.Delay(800);
            progress = 1.0f;
            
            isGenerating = false;
            EditorUtility.DisplayDialog("Nexus Core", "Synthesis Complete. Zero-Asset Project Initialized.", "Execute");
        }
    }
}