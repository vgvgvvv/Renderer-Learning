using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareRenderer.Render
{
    public class MeshRenderer : Renderer
    {
        public Mesh RawMesh { get; set; } = new Mesh();

        public override Mesh GatherMesh()
        {
            return RawMesh;
        }

    }
}
