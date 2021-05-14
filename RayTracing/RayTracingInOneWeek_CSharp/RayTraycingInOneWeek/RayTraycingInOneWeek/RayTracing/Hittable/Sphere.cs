using System;
using System.Numerics;

namespace RayTraycingInOneWeek.RayTracing
{
    public class Sphere : Hittable
    {
        public Vector3 Center;
        public float Radius;

        public Sphere(Vector3 center, float radius, Material material)
        {
            Center = center;
            Radius = radius;
            Material = material;
        }
        
        public override bool Hit(Ray ray, float minT, float maxT, out HitRecord rec)
        {
            Vector3 oc = ray.Origin - Center;
            var a = Vector3.Dot(ray.Direction, ray.Direction);
            var half_b = Vector3.Dot(oc, ray.Direction);
            var c = Vector3.Dot(oc, oc) - Radius * Radius;
            var discriminant = half_b * half_b - a * c;

            rec = new HitRecord();

            if (discriminant > 0)
            {
                var root = Math.Sqrt(discriminant);
                var t = (-half_b - root) / a;
                if (t < maxT && t > minT)
                {
                    rec.t = (float)t;
                    rec.HitPoint = ray.At((float)t);
                    var outwardNormal = (rec.HitPoint - Center) / Radius;
                    rec.SetNormal(ray, outwardNormal);
                    rec.HitMaterial = Material;
                    return true;
                }

                t = (-half_b + root) / a;
                if (t < maxT && t > minT)
                {
                    rec.t = (float)t;
                    rec.HitPoint = ray.At((float)t);
                    // 交点-中心=法线
                    var outwardNormal = (rec.HitPoint - Center) / Radius;
                    rec.SetNormal(ray, outwardNormal);
                    rec.HitMaterial = Material;
                    return true;
                }
            }

            return false;
        }
    }
}