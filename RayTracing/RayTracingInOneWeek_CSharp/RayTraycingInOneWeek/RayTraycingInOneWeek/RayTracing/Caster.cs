
using System;
using System.Drawing;
using System.Numerics;
using RayTraycingInOneWeek.Utility;

namespace RayTraycingInOneWeek.RayTracing
{
    public class World
    {
        public HittableList AllHittable = new HittableList();
        // public Sphere sphere = new Sphere(new Vector3(0, 0, -1), 0.5f);
        
        /// <summary>
        /// 投射获取颜色函数
        /// </summary>
        /// <param name="ray"></param>
        /// <returns></returns>
        public Color CastColor(Ray ray)
        {
            if (AllHittable.Hit(ray, 0, float.MaxValue, out var rec))
            {
                return (0.5f * (rec.Normal + Vector3.One) * 255f).ToColor();
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
                Color.Aquamarine.ToVector(), 
                Color.Aquamarine.ToVector(), t);
            return colorVec.ToColor();
        }
    }
}