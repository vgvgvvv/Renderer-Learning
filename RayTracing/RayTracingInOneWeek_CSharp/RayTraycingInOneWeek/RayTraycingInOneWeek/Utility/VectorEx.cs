using System.Drawing;
using System.Numerics;

namespace RayTraycingInOneWeek.Utility
{
    public static class VectorEx
    {

        public static Color ToColor(this Vector3 vector3)
        {
            return Color.FromArgb((int)vector3.X, (int)vector3.Y, (int)vector3.Z);
        }

        public static Vector3 ToVector(this Color color)
        {
            return new Vector3(color.R, color.G, color.B);
        }
        
    }
}