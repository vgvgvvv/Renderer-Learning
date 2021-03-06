
using EditorGUId;
using ImGUILibd.ImGui;

namespace DotNetDriver.Editor
{
    public class SceneViewPanel : IEditorPanel
    {

        public static SceneViewPanel Current { get; private set; }

        [MenuItem("Window/Open SceneViewPanel")]
        public static void Open()
        {
            Current.IsShow = true;
        }

        public SceneViewPanel()
        {
            Current = this;
        }

        public bool IsShow { get; set; } = true;
        public string Title => "Scene";


        private SceneView nativeSceneView = new SceneView();

        public void OnInit()
        {
            nativeSceneView.OnInit();
        }

        public void OnGUI()
        {
            nativeSceneView.OnGUI();
        }

        public void ShutDown()
        {
            nativeSceneView.ShutDown();
        }
    }
}