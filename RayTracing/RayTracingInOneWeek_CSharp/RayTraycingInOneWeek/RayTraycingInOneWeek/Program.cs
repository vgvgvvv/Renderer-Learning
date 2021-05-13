using System;
using System.Drawing;
using RayTraycingInOneWeek.RayTracing;
using RayTraycingInOneWeek.Utility;

namespace RayTraycingInOneWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            Camera camera = new Camera();
            
            
            int width = 200;
            int height = 100;
            Color[] data = new Color[width * height * 4];
            for (int w = 0; w < width; w++)
            {
                for (int h = 0; h < height; h++)
                {
                    var ray = camera.GetRay(w / (float) width, h / (float) height);
                    data[w + h * width] = world.CastColor(ray);
                }
            }

            var img = ImageHelper.GetDataPicture(width, height, data);
            img.Save("D:/test.jpg");
        }
    }
}
