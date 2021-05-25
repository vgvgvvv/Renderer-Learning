
using MathLib;

namespace SoftwareRenderer.Render
{
    public struct DrawCommand
    {
        public Vertex[] Vertexs;
        public Vector3[] Indexes;
        public Material Mat;
    }
}