
using System;
using System.Drawing;
using System.Numerics;

namespace RayTraycingInOneWeek.RayTracing
{
    public class World
    {
        private Sphere sphere = new Sphere(new Vector3(0, 0, -1), 0.5f);
        
        public Color CastColor(Ray ray)
        {
            HitRecord hitRecord;
            if (sphere.Hit(ray, 0, 0, out hitRecord))
            {
                return Color.Red;
            }
            return BaseColor(ray);
        }

        /// <summary>
        /// 未命中时的基础颜色
        /// </summary>
        /// <param name="ray"></param>
        /// <returns></returns>
        private Color BaseColor(Ray ray)
        {
            var unitDir = Vector3.Normalize(ray.Direction);
            var t = 0.5f * (unitDir.Y + 1);
            var colorVec = Vector3.Lerp( 
                new Vector3(Color.Aquamarine.R, Color.Aquamarine.G, Color.Aquamarine.B), 
                new Vector3(Color.White.R, Color.White.G, Color.White.B), t);
            return Color.FromArgb(255, (int)colorVec.X, (int)colorVec.Y, (int)colorVec.Z);
        }
    }
}