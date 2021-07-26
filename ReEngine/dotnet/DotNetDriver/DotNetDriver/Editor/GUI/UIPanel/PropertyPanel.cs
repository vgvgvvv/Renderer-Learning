using EditorGUId;

namespace DotNetDriver.Editor
{
    public class PropertyPanel : IEditorPanel
    {

        public static PropertyPanel Current { get; private set; }

        [MenuItem("Window/Open PropertyPanel")]
        public static void Open()
        {
            Current.IsShow = true;
        }

        public PropertyPanel()
        {
            Current = this;
        }

        public bool IsShow { get; set; } = true;
        public string Title => "Property";

        private PropertyView view = new PropertyView();

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