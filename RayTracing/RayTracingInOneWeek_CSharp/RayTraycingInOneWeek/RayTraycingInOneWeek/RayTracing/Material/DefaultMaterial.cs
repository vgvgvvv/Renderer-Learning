using System.Drawing;
using System.Numerics;
using RayTraycingInOneWeek.Utility;

namespace RayTraycingInOneWeek.RayTracing
{
    public class Lambertian : Material
    {
        public Color Albedo { get; }
        
        public Lambertian(Color albedo)
        {
            Albedo = albedo;
        }

        /// <summary>
        /// 发散函数
        /// </summary>
        /// <param name="ray"></param>
        /// <param name="rec"></param>
        /// <param name="attenuation"></param>
        /// <param name="scattered"></param>
        /// <returns></returns>
        public override bool Scatter(Ray ray, HitRecord rec, out Color attenuation, out Ray scattered)
        {
            var scatteredDir = rec.Normal + VectorEx.RandomUnitVector();

            if (scatteredDir.IsNearZero())
            {
                scatteredDir = rec.Normal;
            }
            
            scattered = new Ray(rec.HitPoint, scatteredDir);
            attenuation = Albedo;
            return true;
        }
    }
}