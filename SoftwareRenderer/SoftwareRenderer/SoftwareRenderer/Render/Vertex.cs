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

        public Vertex(Vector3 position)
        {
            Position = position;
            UV = Vector2.zero;
        }
        
        public Vertex(Vector3 position, Vector2 uv) : this(position)
        {
            UV = uv;
        }
    }
}
