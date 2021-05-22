using System;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Core
{
    public class Behavior : WorldObject
    {
        public event Action OnUpdate;
        public event Action OnBeforeRender;

        public virtual void Update()
        {
            OnUpdate?.Invoke();
        }

        public virtual void BeforeRender()
        {
            OnBeforeRender?.Invoke();
        }
    }
}
