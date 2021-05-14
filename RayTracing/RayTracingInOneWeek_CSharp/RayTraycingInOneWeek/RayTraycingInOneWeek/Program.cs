using System;
using System.Drawing;
using System.Numerics;
using System.Threading.Tasks;
using RayTraycingInOneWeek.RayTracing;
using RayTraycingInOneWeek.Scene;
using RayTraycingInOneWeek.Utility;

namespace RayTraycingInOneWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 200;
            int height = 100;
            
            World caster = new World();

            Vector3 lookFrom = new Vector3(5, 2, 2);
            Vector3 lookAt = new Vector3(0, 0, -1);
            float fov = 20;
            Vector3 up = new Vector3(0, 1, 0);
            
            float aspect = (float)width / height;
            Camera camera = new Camera(lookFrom, lookAt, up, fov, aspect);

            int boundTimes = 10;
            bool antiAliasing = true;
            int sampleCount = 100;
            Random random = new Random();
            
            Hittable world = RandomScene.GetRandomScene();

            
            Color[] data = new Color[width * height * 4];
           
            //Parallel.For(0, height * width, now =>
            
            for(int w = 0; w < width; w++)
            for(int h = 0; h < height; h++)
            {
                // var w = now % width;
                // var h = now / width;
                    
                if (antiAliasing)
                {
                    Vector3 colorVec = Vector3.Zero;
                    // 抗锯齿多次发射
                    for (int i = 0; i < sampleCount; i++)
                    {
                        float u = (float) (w + random.NextDouble()) / width;
                        float v = (float) (h + random.NextDouble()) / height;
                        var ray = camera.GetRay(u, v);
                        Color color = caster.CastColor(ray, world, boundTimes);
                        colorVec += color.ToVector();
                    }

                    Color currentColor = (colorVec / sampleCount).ToColor();
                    Console.WriteLine($"x:{w} y:{h} color:{currentColor}");

                    data[w + h * width] = currentColor;
                }
            };
            
            var img = ImageHelper.GetDataPicture(width, height, data);
            img.Save("D:/test.jpg");
        }
    }
}
