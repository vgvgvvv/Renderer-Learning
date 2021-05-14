using System.Drawing;
using System.Numerics;

namespace RayTraycingInOneWeek.RayTracing
{
    public abstract class Material
    {
        public abstract bool Scatter(Ray ray, HitRecord rec, out Color attenuation, out Ray scattered);
    }
}