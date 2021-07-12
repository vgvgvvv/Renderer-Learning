
using EditorGUId;
using ImGUILibd.ImGui;

namespace DotNetDriver.Editor
{
    public class SceneViewPanel : IEditorPanel
    {
        public bool IsShow { get; set; } = true;
        public string Title => "Scene";


        private SceneView nativeSceneView = new SceneView();

        public void OnInit()
        {
            nativeSceneView.OnInit();
        }

        public void OnGUI()
        {
            imgui.Text("hasd");
            nativeSceneView.OnGUI();
        }

        public void ShutDown()
        {
            nativeSceneView.ShutDown();
        }
    }
}