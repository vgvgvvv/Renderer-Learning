using MathLib;
using SoftwareRenderer.Core;
using SoftwareRenderer.Render;

namespace SoftwareRenderer
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.GetInstance().Run();

            var camera = WorldObject.Create<Camera>(new Vector3(0, 1, -1));

            var renderer = WorldObject.Create<MeshRenderer>(new Vector3(0, 0, 1));

            renderer.RawMesh.vertexs = new[]
            {
                new Vertex()
            };
        }
    }
}