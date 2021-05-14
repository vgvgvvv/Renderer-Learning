using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace RayTraycingInOneWeek.Utility
{
    public class ImageHelper
    {
        public static Bitmap GetDataPicture(int w, int h, Color[] data)
        {
            Bitmap pic = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

            for (int y = 1; y <= h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    int arrayIndex = y * w + x;
                    pic.SetPixel(x, h-y, data[arrayIndex].ToGammarColor());
                }
            }
            

            return pic;
        } 
    }
}
