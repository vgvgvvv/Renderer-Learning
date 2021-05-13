using System.Numerics;

namespace RayTraycingInOneWeek.RayTracing
{
    public class Ray
    {
        public Vector3 Origin { get; set; }

        public Vector3 Direction { get; set; }
        
        public Ray(Vector3 origin, Vector3 direction)
        {
            Origin = origin;
            Direction = direction;
        }

        /// <summary>
        /// 当前光线所在的位置
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public Vector3 At(float t)
        {
            return Origin + t * Direction;
        }
    }
}