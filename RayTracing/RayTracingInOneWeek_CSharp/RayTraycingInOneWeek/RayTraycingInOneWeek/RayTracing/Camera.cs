using System.Numerics;

namespace RayTraycingInOneWeek.RayTracing
{
    public class Camera
    {
        public Vector3 LowLeftCorner;
        public Vector3 Horizontal;
        public Vector3 Vertical;
        public Vector3 Origin;

        public Camera()
        {
            LowLeftCorner = new Vector3(-2, -1, -1);
            Horizontal = new Vector3(4, 0, 0);
            Vertical = new Vector3(0, 2, 0);
            Origin = new Vector3(0, 0, 0);
        }

        public Ray GetRay(float u, float v)
        {
            return new Ray(Origin, LowLeftCorner + u * Horizontal + v * Vertical - Origin);
        }
    }
}