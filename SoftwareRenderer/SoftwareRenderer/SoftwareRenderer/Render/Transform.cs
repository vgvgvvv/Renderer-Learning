using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SoftwareRenderer.Render
{
    public class Transform
    {
        public Vector3 position = Vector3.Zero;
        public Vector3 scale = Vector3.One;
        public Quaternion rotation = Quaternion.Identity;
    }
}
