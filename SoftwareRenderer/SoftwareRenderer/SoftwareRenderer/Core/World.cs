using System;
using System.Collections.Generic;
using System.Text;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Core
{
    public class World : WorldObject
    {
        public List<WorldObject> Objects { get; } = new List<WorldObject>();

        public virtual void Init()
        {
            
        }
        
        public virtual void Update()
        {
            foreach (var worldObject in Objects)
            {
                if (worldObject is Behavior behavior)
                {
                    behavior.Update();
                }
            }
        }

        public virtual void BeforeRender()
        {
            foreach (var worldObject in Objects)
            {
                if (worldObject is Behavior behavior)
                {
                    behavior.BeforeRender();
                }
            }
        }
    }
}
