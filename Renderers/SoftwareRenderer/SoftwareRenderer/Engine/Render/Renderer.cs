using System;
using System.Collections.Generic;
using System.Text;
using MathLib;
using SoftwareRenderer.Core;

namespace SoftwareRenderer.Render
{
    public abstract class Renderer : Behavior
    {

        public Material Mat { get; set; } = new Material();

        public abstract List<DrawCommand> GatherCommand();
        
        public override void BeforeRender()
        {
            base.BeforeRender();
            Application.Get().RenderSystem.PushDrawCommand(GatherCommand());
        }
    }
}
