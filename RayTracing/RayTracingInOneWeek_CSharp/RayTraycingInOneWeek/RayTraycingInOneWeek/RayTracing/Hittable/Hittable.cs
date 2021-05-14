using System.Numerics;

namespace RayTraycingInOneWeek.RayTracing
{
    public struct HitRecord
    {
        public Vector3 HitPoint;
        public Vector3 Normal;
        public float t;
        public bool FrontFace;
        public Material HitMaterial;

        public void SetNormal(Ray ray, Vector3 outwardNormal)
        {
            FrontFace = Vector3.Dot(ray.Direction, outwardNormal) < 0;
            Normal = FrontFace ? outwardNormal : -outwardNormal;
        }
    }
    
    public abstract class Hittable
    {
        public Material Material { protected set; get; }
        public abstract bool Hit(Ray ray, float minT, float maxT, out HitRecord rec);
    }
}