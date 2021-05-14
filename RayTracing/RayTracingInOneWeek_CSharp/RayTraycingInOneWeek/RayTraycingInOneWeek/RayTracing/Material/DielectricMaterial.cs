using System;
using System.Drawing;
using System.Numerics;
using RayTraycingInOneWeek.Utility;

namespace RayTraycingInOneWeek.RayTracing
{
    public class DielectricMaterial : Material
    {
        public float RefractiveIndex;
        private Random random = new Random();

        public DielectricMaterial(float refractiveIndex)
        {
            RefractiveIndex = refractiveIndex;
        }
        
        public override bool Scatter(Ray ray, HitRecord rec, out Color attenuation, out Ray scattered)
        {
            attenuation = Color.White;
            // 从外往内还是从内往外
            float factor = rec.FrontFace ? 1.0f / RefractiveIndex : RefractiveIndex;

            Vector3 unitIn = Vector3.Normalize(ray.Direction);
            float cosTheta = Math.Min(Vector3.Dot(-unitIn, rec.Normal), 1.0f);
            float sinTheta = (float)Math.Sqrt(1.0f - cosTheta * cosTheta);

            // *反射的情况*
            if (factor * sinTheta > 1.0f)
            {
                Vector3 reflected = unitIn.Reflect(rec.Normal);
                scattered = new Ray(rec.HitPoint, reflected);
                return true;
            }

            float reflect_prob = Schlick(cosTheta, factor);
            if (random.NextFloat() < reflect_prob)
            {
                Vector3 reflected = unitIn.Reflect(rec.Normal);
                scattered = new Ray(rec.HitPoint, reflected);
                return true;
            }
            
            // 折射的情况
            Vector3 refracted = unitIn.Refract(rec.Normal, factor);
            scattered = new Ray(rec.HitPoint, refracted);
            return true;
        }
        
        // 随着入射角改变而改变折射率
        private float Schlick(float cos, float refractive)
        {
            var r0 = (1 - refractive) / (1 + refractive);
            r0 = r0 * r0;
            return (float) (r0 + (1 - r0) * Math.Pow((1 - cos), 5));
        }
        
    }
}