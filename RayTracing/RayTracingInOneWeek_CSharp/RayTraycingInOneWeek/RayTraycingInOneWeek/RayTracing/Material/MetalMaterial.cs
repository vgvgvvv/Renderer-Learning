using System.Drawing;
using System.Numerics;
using RayTraycingInOneWeek.Utility;

namespace RayTraycingInOneWeek.RayTracing
{
    public class MetalMaterial : Material
    {
        // 颜色
        public Color Albedo;
        // 粗糙度
        public float Fuzz;
        
        public MetalMaterial(Color color, float fuzz = 0)
        {
            Albedo = color;
            Fuzz = fuzz > 1 ? 1 : fuzz;
        }
        
        public override bool Scatter(Ray ray, HitRecord rec, out Color attenuation, out Ray scattered)
        {
            var reflectDir = Vector3.Normalize(ray.Direction).Reflect(rec.Normal);
            scattered = new Ray(rec.HitPoint, reflectDir + Fuzz * VectorEx.RandomUnitVector());
            attenuation = Albedo;
            return Vector3.Dot(scattered.Direction, rec.Normal) > 0;
        }
    }
}