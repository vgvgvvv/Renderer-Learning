
using Cored;
using Cored.ImGui;
using DotNetAPId;

namespace DotNetDriver.Editor
{
    public class EditorEntry
    {

        private EditorUI GUI = new EditorUI();
        private SelectProjectUI SelectProject = new SelectProjectUI();

        public void OnInit()
        {
            GUI.OnInit();
            SelectProject.OnInit();
        }

        public void OnGUI()
        {
            if (!string.IsNullOrEmpty(ApplicationAPI.ProjectRoot))
            {
                GUI.OnGUI();
            }
            else
            {
                SelectProject.OnGUI();
            }
        }
    }
}