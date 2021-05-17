using System;
using System.Collections.Generic;
using System.Text;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Core
{
    public interface IRenderer
    {
        public SoftwareRenderDevice Device { get; }
    }
}
