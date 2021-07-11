namespace DotNetDriver.Editor
{
    public interface IEditorPanel
    {
        bool IsShow { get; set; }
        string Title { get; }

        void OnInit();

        void OnGUI();

    }
}