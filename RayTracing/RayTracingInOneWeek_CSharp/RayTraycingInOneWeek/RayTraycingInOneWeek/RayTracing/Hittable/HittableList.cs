using System.Collections.Generic;

namespace RayTraycingInOneWeek.RayTracing
{
    public class HittableList : Hittable
    {
        public List<Hittable> Hittables { get; } = new List<Hittable>();
        
        public bool Hit(Ray ray, float minT, float maxT, out HitRecord rec)
        {
            rec = new HitRecord();

            bool hitAnything = false;
            float closestDistance = maxT;
            
            foreach (var hittable in Hittables)
            {
                if (hittable.Hit(ray, minT, closestDistance, out var result))
                {
                    hitAnything = true;
                    closestDistance = rec.t;
                    rec = result;
                }
            }
            
            return hitAnything;
        }
    }
}