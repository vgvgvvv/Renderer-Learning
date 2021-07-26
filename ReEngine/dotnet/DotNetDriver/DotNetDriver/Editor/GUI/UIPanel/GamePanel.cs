namespace DotNetDriver.Editor
{
    public class GamePanel : IEditorPanel
    {
        public static GamePanel Current { get; private set; }

        [MenuItem("Window/Open GamePanel")]
        public static void Open()
        {
            Current.IsShow = true;
        }

        public GamePanel()
        {
            Current = this;
        }

        public bool IsShow { get; set; } = true;
        public string Title => "Game";

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