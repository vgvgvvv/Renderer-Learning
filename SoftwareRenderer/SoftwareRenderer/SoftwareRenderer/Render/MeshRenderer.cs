using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareRenderer.Render
{
    public class MeshRenderer : Renderer
    {
        public Mesh RawMesh { get; set; } = new Mesh();

        public override Vertex[] GatherMesh()
        {
            var points = RawMesh.Vertexs;
            var result = new Vertex[RawMesh.Indexs.Length * 3];
            for (var i = 0; i < RawMesh.Indexs.Length; i++)
            {
                result[i * 3] = points[(int)RawMesh.Indexs[i][0]];
                result[i * 3 + 1] = points[(int)RawMesh.Indexs[i][1]];
                result[i * 3 + 2] = points[(int)RawMesh.Indexs[i][2]];
            }
            return result;
        }

    }
}
