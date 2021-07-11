using Cored.ImGui;

namespace DotNetDriver.Editor
{
    public class SelectProjectMenu
    {
        public void OnGUI()
        {
            if (imgui.BeginMenuBar())
            {
                OnProject();
            }
            imgui.EndMenuBar();
        }

        private void OnProject()
        {
            if (imgui.BeginMenu("Project", true))
            {

                if (imgui.MenuItem("Open Project", "", false, true))
                {
                }

                imgui.EndMenu();
            }
        }
    }
}