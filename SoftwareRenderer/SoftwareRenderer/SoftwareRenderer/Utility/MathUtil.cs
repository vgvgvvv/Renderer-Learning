using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SoftwareRenderer.Utility
{
    public class MathUtil
    {
        public Matrix4x4 GetMoveMat(float x, float y, float z)
        {
            return new Matrix4x4(1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 0,
                x, y, z, 1);
        }

        public Matrix4x4 GetScaleMat(float x, float y, float z)
        {
            return new Matrix4x4(
                x, 0, 0, 0,
                0, y, 0, 0, 
                0, 0, z, 0, 
                0, 0, 0, 1);
        }

        public static Matrix4x4 GetRotateY(float r)
        {
            Matrix4x4 rm = Matrix4x4.Identity;
            rm.M11 = (float)(Math.Cos(r));
            rm.M13 = (float)(-Math.Sin(r));
            rm.M31 = (float)(Math.Sin(r));
            rm.M33 = (float)(Math.Cos(r));
            return rm;
        }

        public static Matrix4x4 GetRotateX(float r)
        {
            Matrix4x4 rm = Matrix4x4.Identity;
            rm.M22 = (float)(Math.Cos(r));
            rm.M23 = (float)(Math.Sin(r));
            rm.M32 = (float)(-Math.Sin(r));
            rm.M33 = (float)(Math.Cos(r));
            return rm;
        }

        public static Matrix4x4 GetRotateZ(float r)
        {
            Matrix4x4 rm = Matrix4x4.Identity;
            rm.M11 = (float)(Math.Cos(r));
            rm.M12 = (float)(Math.Sin(r));
            rm.M21 = (float)(-Math.Sin(r));
            rm.M22 = (float)(Math.Cos(r));
            return rm;
        }

    }
}
