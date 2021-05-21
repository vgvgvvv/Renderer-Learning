using System;
using System.Collections.Generic;
using System.Text;
using MathLib;

namespace SoftwareRenderer.Render
{
    public class Transform
    {
        public Vector3 position = Vector3.zero;
        public Vector3 scale = Vector3.one;
        public Vector3 eulerAngle => rotation.eulerAngles;
        public Quaternion rotation = Quaternion.identity;
    }
}
