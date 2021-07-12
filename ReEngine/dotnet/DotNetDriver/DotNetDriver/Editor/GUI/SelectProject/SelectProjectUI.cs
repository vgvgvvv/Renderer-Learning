
namespace DotNetDriver.Editor
{
    public class SelectProjectUI
    {
        private SelectProjectMenu Menu = new SelectProjectMenu();

        private SelectProjectPanel Panel = new SelectProjectPanel();

        public void OnInit()
        {

        }

        public void OnGUI()
        {
            DockSpace.BeginDockSpace();

            Menu.OnGUI();
            Panel.OnGUI();

            DockSpace.EndDockSpace();
        }

        public void ShutDown()
        {

        }
    }
}