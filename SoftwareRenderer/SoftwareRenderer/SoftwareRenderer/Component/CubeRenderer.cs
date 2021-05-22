using MathLib;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Component
{
    public class CubeRenderer : MeshRenderer
    {
        public CubeRenderer()
        {
            RawMesh.Vertexs = new Vertex[]
            {
                new Vertex(new Vector3(-0.5f,  0.5f, -0.5f)),
                new Vertex(new Vector3(-0.5f,  -0.5f, -0.5f)),
                new Vertex(new Vector3(0.5f,  -0.5f, -0.5f)),
                new Vertex(new Vector3(0.5f, 0.5f, -0.5f)),

                new Vertex(new Vector3(-0.5f,  0.5f, 0.5f)),
                new Vertex(new Vector3(-0.5f,  -0.5f, 0.5f)),
                new Vertex(new Vector3(0.5f,  -0.5f, 0.5f)),
                new Vertex(new Vector3(0.5f,  0.5f, 0.5f)),
            };

            RawMesh.Indexs = new Vector3[]
            {
                new Vector3(0, 1, 2),
                new Vector3(0, 2, 3),
                new Vector3(7, 6, 5),
                new Vector3(7, 5, 4),
                new Vector3(0, 4, 5),
                new Vector3(0, 5, 1),
                new Vector3(1, 5, 6),
                new Vector3(1, 6, 2),
                new Vector3(2, 6, 7),
                new Vector3(2, 7, 3),
                new Vector3(3, 7, 4),
                new Vector3(3, 4, 0),
            };

        }
    }
}