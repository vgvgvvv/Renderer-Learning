using Common;
using ImGUILibd.ImGui;

namespace DotNetDriver.Editor
{
    public class SelectProjectPanel
    {
        public void OnGUI()
        {
            bool open = true;
            imgui.Begin("Main", ref open, 0);

            imgui.Text("Please select target path");

            imgui.End();
        }
    }
}