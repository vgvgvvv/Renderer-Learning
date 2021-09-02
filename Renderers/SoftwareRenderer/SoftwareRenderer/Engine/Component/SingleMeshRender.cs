using System.Collections.Generic;
using SoftwareRenderer.Core;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Component
{
    public abstract class SingleMeshRender : Renderer 
    {
        public Mesh RawMesh { get; set; } = new Mesh();

        public virtual Mesh GatherMesh()
        {
            return RawMesh;
        }

        public override List<DrawCommand> GatherCommand()
        {
            Mesh mesh = GatherMesh();
            var result = new Vertex[mesh.Vertexs.Length];
            for (var i = 0; i < result.Length; i++)
            {
                result[i].Position = Transform.TransformMat.MultiplyPoint(mesh.Vertexs[i].Position);
                result[i].Normal = mesh.Vertexs[i].Normal;
                result[i].Color = mesh.Vertexs[i].Color;
                result[i].UV = mesh.Vertexs[i].UV;
            }
           
            var drawCommand = new DrawCommand()
            {
                Vertexs = result,
                Indexes = mesh.Indexs,
                Mat = Mat
            };
            return new List<DrawCommand>() {drawCommand};
        }
    }
}