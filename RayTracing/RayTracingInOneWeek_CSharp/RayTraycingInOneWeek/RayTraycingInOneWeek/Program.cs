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

            float fov = 90;
            int width = 200;
            int height = 100;
            float aspect = (float)width / 100;
            Camera camera = new Camera(new Vector3(-1, 1, 1), new Vector3(0, 0, -1), Vector3.UnitY, fov, aspect);

            int boundTimes = 5;
            HittableList AllHittable = new HittableList();

            var Color1 = Color.FromArgb((int) (255 * 0.7f), (int) (255 * 0.3f), (int) (255 * 0.3f));
            var Color2 = Color.FromArgb((int)(255 * 0.8f), (int)(255 * 0.8f), (int)(255 * 0.8f));
            var Color3 = Color.FromArgb((int)(255 * 0.8f), (int)(255 * 0.6f), (int)(255 * 0.2f));
            var Color4 = Color.FromArgb((int)(255 * 0.8f), (int)(255 * 0.8f), (int)(255 * 0f));
            
            AllHittable.Hittables.AddRange(new []
            {
                new Sphere(new Vector3(0, 0, -1), 0.5f, new Lambertian(Color1)),
                // new Sphere(new Vector3(-1, 0, -1f), -0.49f, new DielectricMaterial(1.5f)),
                new Sphere(new Vector3(-1, 0, -1f), 0.5f, new DielectricMaterial(1.5f)),
                new Sphere(new Vector3(1, 0, -1f), 0.5f, new MetalMaterial(Color3, 0.1f)),
                
                new Sphere(new Vector3(0, -100.5f, -1), 100f, new Lambertian(Color4)),
            });
            
            
            

            bool antiAliasing = true;
            int sampleCount = 100;
            Random random = new Random();
            
            Color[] data = new Color[width * height * 4];
           
            for (int w = 0; w < width; w++)
            {
                for (int h = 0; h < height; h++)
                {
                    //抗锯齿随机采样 Anti-aliasing
                    if(antiAliasing)
                    {
                        Vector3 colorVec = Vector3.Zero;
                        for (int i = 0; i < sampleCount; i++)
                        {
                            float u = (float)(w + random.NextDouble()) / width;
                            float v = (float) (h + random.NextDouble()) / height;
                            var ray = camera.GetRay(u, v);
                            Color color = world.CastColor(ray, AllHittable, boundTimes);
                            colorVec += color.ToVector();
                        }

                        data[w + h * width] = (colorVec / sampleCount).ToColor();
                    }
                    else
                        // 无抗锯齿
                    {
                        var ray = camera.GetRay(w / (float)width, h / (float)height);
                        Color color = world.CastColor(ray, AllHittable, boundTimes);
                        data[w + h * width] = color;
                    }
                    
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
