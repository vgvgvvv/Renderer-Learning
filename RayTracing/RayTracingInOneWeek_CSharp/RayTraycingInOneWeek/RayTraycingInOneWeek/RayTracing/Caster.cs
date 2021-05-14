
using System;
using System.Drawing;
using System.Numerics;
using RayTraycingInOneWeek.Utility;

namespace RayTraycingInOneWeek.RayTracing
{
    public class World
    {
        /// <summary>
        /// 投射获取颜色函数
        /// </summary>
        /// <param name="ray"></param>
        /// <param name="world"></param>
        /// <param name="boundTimes"></param>
        /// <param name="falloff"></param>
        /// <returns></returns>
        public Color CastColor(Ray ray, Hittable world, int boundTimes)
        {
            if (boundTimes <= 0)
            {
                return Color.Black;
            }
            
            //这里的0.001是为了防止自相交问题导致的光照偏暗
            if (world.Hit(ray, 0.001f, float.MaxValue, out var rec))
            {
                Ray scattered;
                Color attenuation;
                if (rec.HitMaterial.Scatter(ray, rec, out attenuation, out scattered))
                {
                    Vector3 Color = (attenuation.ToVector() / 255f) *
                                    (CastColor(scattered, world, boundTimes - 1).ToVector() / 255f) * 255f;
                    return Color.ToColor();
                }
                
                return Color.Black;

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
                Color.White.ToVector(), 
                Color.White.ToVector(), t);
            return colorVec.ToColor();
        }
    }
}