namespace DotNetDriver
{
    public class Entry
    {
		public virtual void OnInit() { }
        public virtual void OnPreUpdate() { }
        public virtual void OnUpdate() { }
        public virtual void OnLateUpdate() { }
        public virtual void OnBeforeRender() { }
        public virtual void OnRender() { }
        public virtual void OnAfterRender() { }
        public virtual void OnShutDown() { }
    }
}