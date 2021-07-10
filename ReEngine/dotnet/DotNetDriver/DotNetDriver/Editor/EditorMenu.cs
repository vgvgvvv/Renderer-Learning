using Common;
using TestOpenGLd.ImGui;

namespace DotNetDriver.Editor
{
    public class EditorMenu
    {
        public void OnGUI()
        {
            if (imgui.BeginMenuBar())
            {
                if (imgui.BeginMenu("Files", true))
                {
                    if (imgui.MenuItem("OpenScene", "", false, true))
                    {
                        Log.Info("On Open Scene");
                    }
                    imgui.EndMenu();
                }
                if (imgui.BeginMenu("Help", true))
                {
                    if (imgui.MenuItem("About", "", false, true))
                    {
                        Log.Info("On About");
                    }
                    imgui.EndMenu();
                }
            }
            imgui.EndMenuBar();
        }
    }
}