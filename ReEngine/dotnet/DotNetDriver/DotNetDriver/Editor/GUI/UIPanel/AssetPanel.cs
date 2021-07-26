using EditorGUId;

namespace DotNetDriver.Editor
{
    public class AssetPanel : IEditorPanel
    {

        public static AssetPanel Current { get; private set; }

        [MenuItem("Window/Open AssetPanel")]
        public static void Open()
        {
            Current.IsShow = true;
        }

        public AssetPanel()
        {
            Current = this;
        }

        public bool IsShow { get; set; } = true;
        public string Title => "Asset";

        private AssetView view = new AssetView();

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