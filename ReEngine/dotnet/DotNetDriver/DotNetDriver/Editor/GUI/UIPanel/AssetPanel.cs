namespace DotNetDriver.Editor
{
    public class AssetPanel : IEditorPanel
    {
        public bool IsShow { get; set; } = true;
        public string Title => "Asset";
        public void OnInit()
        {
        }

        public void OnGUI()
        {
        }

        public void ShutDown()
        {
            
        }
    }
}