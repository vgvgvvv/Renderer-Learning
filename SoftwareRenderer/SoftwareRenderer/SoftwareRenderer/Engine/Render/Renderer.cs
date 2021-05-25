using System;
using System.Collections.Generic;
using System.Text;
using MathLib;
using SoftwareRenderer.Core;

namespace SoftwareRenderer.Render
{
    public abstract class Renderer : Behavior
    {

        public abstract Vertex[] GatherMesh();
        
        public Material Mat { get; set; } = new Material();

        public DrawCommand GatherCommand()
        {
            Vertex[] meshVertexs = GatherMesh();
            var result = new Vertex[meshVertexs.Length];
            for (var i = 0; i < result.Length; i++)
            {
                result[i].Position = Transform.TransformMat.MultiplyPoint(meshVertexs[i].Position);
                result[i].Normal = meshVertexs[i].Normal;
                result[i].Color = meshVertexs[i].Color;
                result[i].UV = meshVertexs[i].UV;
            }

           
            var drawCommand = new DrawCommand()
            {
                Vertexs = result,
                Mat = Mat
            };
            return drawCommand;
        }
        
        public override void BeforeRender()
        {
            base.BeforeRender();
            Application.Get().RenderSystem.PushDrawCommand(GatherCommand());
        }
    }
}
