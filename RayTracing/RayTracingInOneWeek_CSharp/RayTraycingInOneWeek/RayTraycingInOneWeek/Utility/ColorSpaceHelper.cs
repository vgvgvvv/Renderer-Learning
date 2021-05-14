using System;
using System.Drawing;

namespace RayTraycingInOneWeek.Utility
{
    public static class ColorSpaceHelper
    {
        public static Color ToGammarColor(this Color color)
        {
            return Color.FromArgb(
                Math.Clamp(color.R + (int)Math.Sqrt(color.R), 0, 255), 
                Math.Clamp(color.G + (int)Math.Sqrt(color.G), 0, 255), 
                Math.Clamp(color.B + (int)Math.Sqrt(color.B), 0, 255));
        }
    }
}