using System.Numerics;

namespace RayTraycingInOneWeek.RayTracing
{
    public class Sphere : Hittable
    {
        public Vector3 Center;
        public float Radius;

        public Sphere(Vector3 center, float radius)
        {
            Center = center;
            Radius = radius;
        }
        
        public bool Hit(Ray ray, float minT, float maxT, out HitRecord rec)
        {
            Vector3 oc = ray.Origin - Center;
            var a = Vector3.Dot(ray.Direction, ray.Direction);
            var b = 2.0f * Vector3.Dot(oc, ray.Direction);
            var c = Vector3.Dot(oc, oc) - Radius * Radius;
            var discriminant = b * b - 4 * a * c;

            rec = new HitRecord();
            
            return discriminant > 0;
        }
    }
}