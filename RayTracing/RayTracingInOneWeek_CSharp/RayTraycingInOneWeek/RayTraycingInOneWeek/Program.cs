using System;
using System.Drawing;
using System.Numerics;
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
            
            world.AllHittable.Hittables.AddRange(new []
            {
                new Sphere(new Vector3(0, 0, -1), 0.5f),
                new Sphere(new Vector3(0, -100.5f, -1), 100f),
            });
            
            int width = 200;
            int height = 100;
            Color[] data = new Color[width * height * 4];
           
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    var ray = camera.GetRay(w / (float) width, h / (float) height);
                    data[w + h * width] = world.CastColor(ray);
                    
                    // Show UV Color
                    // var r = w / (float)width;
                    // var g = h / (float)height;
                    // var b = 0.2;
                    // data[w + h * width] = Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
                    //
                }
            }

            var img = ImageHelper.GetDataPicture(width, height, data);
            img.Save("D:/test.jpg");
        }
    }
}
