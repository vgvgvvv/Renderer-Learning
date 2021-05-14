using System;

namespace RayTraycingInOneWeek.Utility
{
    public static class RandomEx
    {
        public static float NextFloat(this Random random)
        {
            return (float) random.NextDouble();
        }
        
        public static float NextFloat(this Random random, float min, float max)
        {
            return min + (float) random.NextDouble() * (max - min);
        }
    }
}