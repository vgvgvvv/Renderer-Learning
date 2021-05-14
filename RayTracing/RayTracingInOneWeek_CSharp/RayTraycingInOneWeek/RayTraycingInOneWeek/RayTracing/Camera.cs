using System;
using System.Numerics;

namespace RayTraycingInOneWeek.RayTracing
{
    public class Camera
    {
        public Vector3 Origin;

        public float Fov;
        public float Aspect;
        public Vector3 Forward = -Vector3.UnitZ;

        private Vector3 LowLeftCorner;
        private Vector3 Horizontal;
        private Vector3 Vertical;
        
        public Camera(Vector3 lookFrom, Vector3 lookAt, Vector3 up, float fov, float aspect)
        {
            Fov = fov;
            Aspect = aspect;
            Origin = lookFrom;
            
            var halfHeight = (float)Math.Tan(Fov / 2);
            var halfWidth = halfHeight * Aspect;

            Vector3 w = Vector3.Normalize(lookFrom - lookAt);
            Vector3 u = Vector3.Normalize(Vector3.Cross(up, w));
            Vector3 v = Vector3.Cross(w, u);


            LowLeftCorner = Origin - halfWidth * u - halfHeight * v - w;//new Vector3(-halfHeight, -halfWidth, 0);
            Horizontal = 2 * halfWidth * u;//new Vector3(2 * halfHeight, 0, 0);
            Vertical = 2 * halfHeight * v; //new Vector3(0, 2 * halfWidth, 0);
        }

        public Ray GetRay(float u, float v)
        {
            return new Ray(Origin, LowLeftCorner + u * Horizontal + v * Vertical - Origin);
        }

        private float DegreeToRadian(float degree)
        {
            return degree * (float)Math.PI / 180f;
        }
    }
}