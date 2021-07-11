namespace DotNetDriver.Editor
{
    public class SelectProjectUI
    {
        private SelectProjectMenu Menu = new SelectProjectMenu();

        public void OnInit()
        {

        }

        public void OnGUI()
        {
            DockSpace.BeginDockSpace();

            Menu.OnGUI();

            DockSpace.EndDockSpace();
        }
    }
}