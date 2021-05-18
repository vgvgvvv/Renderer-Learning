using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareRenderer.Utility
{
    public struct Vector3
    {
        public const float kEpsilon = 0.00001f;
        public const float kEpsilonNormalSqrt = 1e-15F;

        public float x;
        public float y;
        public float z;

        public Vector3(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }
        public Vector3(float x, float y) { this.x = x; this.y = y; z = 0F; }

        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            t = Mathf.Clamp01(t);
            return new Vector3(
                a.x + (b.x - a.x) * t,
                a.y + (b.y - a.y) * t,
                a.z + (b.z - a.z) * t
            );
        }
    }
}
