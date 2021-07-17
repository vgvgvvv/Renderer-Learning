using EditorGUId;
using Worldd;

namespace DotNetDriver.Editor
{
    public class WorldOutlinePanel : IEditorPanel
    {
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