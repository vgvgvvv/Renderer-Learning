using Cored;
using Cored.ImGui;

namespace DotNetDriver.Editor
{
    public class DockSpace
    {

        private static ImGuiDockNodeFlags dockSpaceFlags = ImGuiDockNodeFlags.ImGuiDockNodeFlagsNone;

        public static void BeginDockSpace()
        {
            ImGuiWindowFlags windowFlags =
                ImGuiWindowFlags.ImGuiWindowFlagsMenuBar | ImGuiWindowFlags.ImGuiWindowFlagsNoDocking;

            var viewport = imgui.GetMainViewport();
            imgui.SetNextWindowPos(viewport.WorkPos, 0, new ImVec2());
            imgui.SetNextWindowSize(viewport.WorkSize, 0);
            imgui.SetNextWindowViewport(viewport.ID);
            imgui.PushStyleVar((int)ImGuiStyleVar.ImGuiStyleVarWindowRounding, 0.0f);
            imgui.PushStyleVar((int)ImGuiStyleVar.ImGuiStyleVarWindowBorderSize, 0.0f);

            windowFlags |= ImGuiWindowFlags.ImGuiWindowFlagsNoTitleBar | ImGuiWindowFlags.ImGuiWindowFlagsNoCollapse |
                           ImGuiWindowFlags.ImGuiWindowFlagsNoResize | ImGuiWindowFlags.ImGuiWindowFlagsNoMove |
                           ImGuiWindowFlags.ImGuiWindowFlagsNoBringToFrontOnFocus |
                           ImGuiWindowFlags.ImGuiWindowFlagsNoNavFocus;

            // imgui.PushStyleVar((int)ImGuiStyleVar.ImGuiStyleVarWindowPadding, new ImVec2(0.0f, 0.0f));
            bool open = true;
            imgui.Begin("DockSpace", ref open, (int)windowFlags);
            // imgui.PopStyleVar(1);

            imgui.PopStyleVar(2);

            var io = imgui.GetIO();
            var dockerSpaceId = imgui.GetID("Main Dock Space");
            imgui.DockSpace(dockerSpaceId, new ImVec2(0, 0), (int)dockSpaceFlags, null);
        }

        public static void EndDockSpace()
        {
            imgui.End();
        }
    }
}