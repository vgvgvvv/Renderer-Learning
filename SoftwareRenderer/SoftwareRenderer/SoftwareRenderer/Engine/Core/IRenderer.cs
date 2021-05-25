using System;
using System.Collections.Generic;
using System.Text;
using MathLib;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Core
{
    public interface IRenderer
    {
        public SoftwareRenderDevice Device { get; }

        public void PushDrawCommand(DrawCommand command);

        public void Init();
        public void Update();
        public void Uninit();
        
        public void SetViewMat(Matrix4x4 mat);
        public void SetProjectorMat(Matrix4x4 mat);
    }
}
