using System;
using System.Collections.Generic;
using System.Text;
using SoftwareRenderer.Core;

namespace SoftwareRenderer.Render
{
    public abstract class Renderer : Behavior
    {

        public abstract Mesh GatherMesh();

        public DrawCommand GatherCommand()
        {
            Mesh mesh = GatherMesh();
            var drawCommand = new DrawCommand()
            {
                Vertexs = new Vertex[mesh.Vertexs.Length],
                Indexs = mesh.Indexs
            };
            for (var i = 0; i < drawCommand.Vertexs.Length; i++)
            {
                drawCommand.Vertexs[i] = new Vertex(Transform.TransformMat.MultiplyPoint(mesh.Vertexs[i].Position));
            }
            return drawCommand;
        }
        
        public override void BeforeRender()
        {
            base.BeforeRender();
            Application.Get().RenderSystem.PushDrawCommand(GatherCommand());
        }
    }
}
