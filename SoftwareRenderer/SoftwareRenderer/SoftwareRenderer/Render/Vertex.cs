using System;
using System.Collections.Generic;
using System.Text;
using MathLib;

namespace SoftwareRenderer.Render
{
    public struct Vertex
    {
        public Vector3 Position;
        public Vector2 UV;
        public Vector3 Normal;
        public Color Color;

        internal bool NeedClip;

        public Vertex(Vector3 position)
        {
            Position = position;
            UV = Vector2.zero;
            Normal = Vector3.zero;
            Color = Color.gray;
            NeedClip = false;
        }
        
        public Vertex(Vector3 position, Vector2 uv) : this(position)
        {
            UV = uv;
        }

        public static Vertex Lerp(Vertex v1, Vertex v2, float t)
        {
            Vertex vertex = new Vertex();
            vertex.Position = Vector3.Lerp(v1.Position, v2.Position, t);
            vertex.Normal = Vector3.Lerp(v1.Normal, v2.Normal, t);
            vertex.UV = Vector2.Lerp(v1.UV, v2.UV, t);
            vertex.Color = Color.Lerp(v1.Color, v2.Color, t);
            return vertex;
        }
        
        public void ApplyTransform(Matrix4x4 transformMat)
        {
            Position = transformMat.MultiplyPoint(Position);
        }
    }
}
