using EditorGUId;

namespace DotNetDriver.Editor
{
    public class WorldOutlinePanel : IEditorPanel
    {

        public static WorldOutlinePanel Current { get; private set; }

        [MenuItem("Window/Open WorldOutlinePanel")]
        public static void Open()
        {
            Current.IsShow = true;
        }

        public WorldOutlinePanel()
        {
            Current = this;
        }
        public bool IsShow { get; set; } = true;
        public string Title => "World Outline";

        private WorldOutlineView view = new WorldOutlineView();

        public void OnInit()
        {
            view.OnInit();
        }

        public void OnGUI()
        {
            view.OnGUI();
        }

        public void ShutDown()
        {
            view.ShutDown();
        }
    }
}