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
            Bitmap pic = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    int arrayIndex = y * w + x;
                    pic.SetPixel(x, y, data[arrayIndex]);
                }
            }

            return pic;
        } 
    }
}
