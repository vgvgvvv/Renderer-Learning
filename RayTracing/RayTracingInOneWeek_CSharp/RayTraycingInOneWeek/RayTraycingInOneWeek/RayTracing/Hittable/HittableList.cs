namespace RayTraycingInOneWeek.RayTracing
{
    public class HittableList : Hittable
    {
        public bool Hit(Ray ray, float minT, float maxT, out HitRecord rec)
        {
            rec = new HitRecord();
            return false;
        }
    }
}