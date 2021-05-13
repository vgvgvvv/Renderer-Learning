using System.Numerics;

namespace RayTraycingInOneWeek.RayTracing
{
    public class HitRecord
    {
        public Vector3 HitPoint;
        public Vector3 Normal;
        public float t;
    }
    
    public interface Hittable
    {
        bool Hit(Ray ray, float minT, float maxT, out HitRecord rec);
    }
}