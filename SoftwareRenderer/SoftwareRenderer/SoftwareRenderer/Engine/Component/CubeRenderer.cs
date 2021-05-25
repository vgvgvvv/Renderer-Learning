using System.Collections.Generic;
using MathLib;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Component
{
    public class CubeRenderer : SingleMeshRender
    {
        #region 方块数据

        private Vector2[] uvs ={
                new Vector2(0, 0),new Vector2( 0, 1),new Vector2(1, 1),
                new Vector2(0, 0),new Vector2(1, 1),new Vector2(1, 0),
                //
                new Vector2(0, 0),new Vector2( 0, 1),new Vector2(1, 1),
                new Vector2(0, 0),new Vector2(1, 1),new Vector2(1, 0),
                //
                new Vector2(0, 0),new Vector2( 0, 1),new Vector2(1, 1),
                new Vector2(0, 0),new Vector2(1, 1),new Vector2(1, 0),
                //
                new Vector2(0, 0),new Vector2( 0, 1),new Vector2(1, 1),
                new Vector2(0, 0),new Vector2(1, 1),new Vector2(1, 0),
                //
                new Vector2(0, 0),new Vector2( 0, 1),new Vector2(1, 1),
                new Vector2(0, 0),new Vector2(1, 1),new Vector2(1, 0),
                ///
                new Vector2(0, 0),new Vector2( 0, 1),new Vector2(1, 1),
                new Vector2(0, 0),new Vector2(1, 1),new Vector2(1, 0)
            };
            
        private Color[] vertColors = {
                new Color( 0, 1, 0), new Color( 0, 0, 1), new Color( 1, 0, 0),
                new Color( 0, 1, 0), new Color( 1, 0, 0), new Color( 0, 0, 1),
                //
                new Color( 0, 1, 0), new Color( 0, 0, 1), new Color( 1, 0, 0),
                new Color( 0, 1, 0), new Color( 1, 0, 0), new Color( 0, 0, 1),
                //
                new Color( 0, 1, 0), new Color( 0, 0, 1), new Color( 1, 0, 0),
                new Color( 0, 1, 0), new Color( 1, 0, 0), new Color( 0, 0, 1),
                //
                new Color( 0, 1, 0), new Color( 0, 0, 1), new Color( 1, 0, 0),
                new Color( 0, 1, 0), new Color( 1, 0, 0), new Color( 0, 0, 1),
                //
                new Color( 0, 1, 0), new Color( 0, 0, 1), new Color( 1, 0, 0),
                new Color( 0, 1, 0), new Color( 1, 0, 0), new Color( 0, 0, 1),
                //
                new Color( 0, 1, 0), new Color( 0, 0, 1), new Color( 1, 0, 0),
                new Color( 0, 1, 0), new Color( 1, 0, 0), new Color( 0, 0, 1)
            };
            
        private Vector3[] normals = {
                new Vector3( 0, 0, -1), new Vector3(0, 0, -1), new Vector3( 0, 0, -1),
                new Vector3(0, 0, -1), new Vector3( 0, 0, -1), new Vector3( 0, 0, -1),
                //
                new Vector3( 0, 0, 1), new Vector3( 0, 0, 1), new Vector3( 0, 0, 1),
                new Vector3( 0, 0, 1), new Vector3( 0, 0, 1), new Vector3( 0, 0, 1),
                //
                new Vector3( -1, 0, 0), new Vector3( -1, 0, 0), new Vector3( -1, 0, 0),
                new Vector3( -1, 0, 0), new Vector3(-1, 0, 0), new Vector3( -1, 0, 0),
                //
                new Vector3( 0, -1, 0), new Vector3(  0, -1, 0), new Vector3(  0, -1, 0),
                new Vector3(  0, -1, 0), new Vector3( 0, -1, 0), new Vector3( 0, -1, 0),
                //
                new Vector3( 1, 0, 0), new Vector3( 1, 0, 0), new Vector3( 1, 0, 0),
                new Vector3( 1, 0, 0), new Vector3( 1, 0, 0), new Vector3( 1, 0, 0),
                //
                new Vector3( 0, 1, 0), new Vector3( 0, 1, 0), new Vector3( 0, 1, 0),
                new Vector3( 0, 1, 0 ), new Vector3(0, 1, 0), new Vector3( 0, 1, 0)
            };

        Vertex[] Points = new Vertex[]
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
        
        Vector3[] Indexs = new Vector3[]
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
        
        #endregion
        
        
        public CubeRenderer()
        {
            var points = Points;
            var result = new Vertex[Indexs.Length * 3];
            for (var i = 0; i < Indexs.Length; i++)
            {
                var index1 = (int) Indexs[i][0];
                var v1 = new Vertex()
                {
                    Position = points[index1].Position, 
                    Color = vertColors[i * 3], 
                    Normal = normals[i * 3],
                    UV = uvs[i * 3]
                };
                result[i * 3] = v1;
                
                var index2 = (int) Indexs[i][1];
                var v2 = new Vertex()
                {
                    Position = points[index2].Position, 
                    Color = vertColors[i * 3 + 1], 
                    Normal = normals[i * 3 + 1],
                    UV = uvs[i * 3 + 1]
                };
                result[i * 3 + 1] = v2;
                
                var index3 = (int) Indexs[i][2];
                var v3 = new Vertex()
                {
                    Position = points[index3].Position, 
                    Color = vertColors[i * 3 + 2], 
                    Normal = normals[i * 3 + 2],
                    UV = uvs[i * 3 + 2]
                };
                result[i * 3 + 2] = v3;
            }

            RawMesh.Vertexs = result;

            var indexes = new Vector3[RawMesh.Vertexs.Length / 3];
            for (var i = 0; i+2 < RawMesh.Vertexs.Length; i+=3)
            {
                indexes[i / 3] = new Vector3(i, i + 1, i + 2);
            }

            RawMesh.Indexs = indexes;
        }



    }
}