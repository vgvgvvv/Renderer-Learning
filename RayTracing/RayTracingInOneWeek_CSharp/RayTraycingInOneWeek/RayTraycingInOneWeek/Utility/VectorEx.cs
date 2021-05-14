using System;
using System.Drawing;
using System.Numerics;

namespace RayTraycingInOneWeek.Utility
{
    public static class VectorEx
    {
        private static Random random = new Random();

        public static Color ToColor(this Vector3 vector3)
        {
            return Color.FromArgb((int)vector3.X, (int)vector3.Y, (int)vector3.Z);
        }

        public static Vector3 ToVector(this Color color)
        {
            return new Vector3(color.R, color.G, color.B);
        }

        public static Vector3 Random()
        {
            return new Vector3(random.NextFloat(), random.NextFloat(), random.NextFloat());
        }

        public static Vector3 Random(float min, float max)
        {
            return new Vector3(random.NextFloat(min, max), random.NextFloat(min, max), random.NextFloat(min, max));
        }

        public static Vector3 RandomInSphere()
        {
            while (true)
            {
                var result = Random(-1, 1);
                if(result.LengthSquared() >= 1) continue;
                return result;
            }
        }

        public static Vector3 RandomUnitVector()
        {
            var a = random.NextFloat(0, 2 * (float)Math.PI);
            var z = random.NextFloat(-1, 1);
            var r = (float)Math.Sqrt(1 - z * z);
            return new Vector3(r * (float)Math.Cos(a), r * (float)Math.Sin(a), z);
        }

        public static bool IsNearZero(this Vector3 vector3)
        {
            return Math.Abs(vector3.X) < float.Epsilon && Math.Abs(vector3.Y) < float.Epsilon &&
                   Math.Abs(vector3.Z) < float.Epsilon;
        }

        /// <summary>
        /// 反射公式
        /// </summary>
        /// <param name="inVec"></param>
        /// <param name="normal"></param>
        /// <returns></returns>
        public static Vector3 Reflect(this Vector3 inVec, Vector3 normal)
        {
            return inVec - 2 * Vector3.Dot(inVec, normal) * normal;
        }
        
        /// <summary>
        /// 折射公式
        /// </summary>
        /// <param name="inVec">入射光线</param>
        /// <param name="normal">法线</param>
        /// <param name="factor">折射率</param>
        /// <returns></returns>
        public static Vector3 Refract(this Vector3 inVec, Vector3 normal, float factor)
        {
            var cosTheta = Vector3.Dot(-inVec, normal);
            var rOutParallel = factor * (inVec + cosTheta * normal);
            var rOutPerp = -(float)Math.Sqrt(1.0 - rOutParallel.LengthSquared()) * normal;
            return rOutParallel + rOutPerp;
        }
    }
}