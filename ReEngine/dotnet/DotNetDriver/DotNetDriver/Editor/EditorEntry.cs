namespace DotNetDriver.Editor
{
    public class EditorEntry
    {

        private EditorUI GUI = new EditorUI();

        public void OnInit()
        {
            GUI.OnInit();
        }

        public void OnGUI()
        {
            GUI.OnGUI();
        }
    }
}