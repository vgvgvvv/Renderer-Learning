using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareRenderer.Render
{
    public class MeshRenderer : Renderer
    {
        public Mesh RawMesh { get; set; } = new Mesh();

        public MeshRenderer() { }

        public override void Update()
        {
            base.Update();
        }

        public override Mesh GatherMesh()
        {
            return RawMesh;
        }

    }
}
