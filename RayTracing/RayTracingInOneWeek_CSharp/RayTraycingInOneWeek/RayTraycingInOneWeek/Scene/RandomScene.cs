using System;
using System.Drawing;
using System.Numerics;
using RayTraycingInOneWeek.RayTracing;
using RayTraycingInOneWeek.Utility;

namespace RayTraycingInOneWeek.Scene
{
    public class RandomScene
    {
        public static Hittable GetRandomScene()
        {
            Random random = new Random();
            HittableList AllHittable = new HittableList();
            
            AllHittable.Hittables.Add(new Sphere(new Vector3(0, -1000, 0), 1000, new Lambertian(Color.Gray)));
            
            int i = 1;
            for (int a = -11; a < 11; a++)
            {
                for (int b = -11; b < 11; b++)
                {
                    var chooseMat = random.NextFloat();
                    var center = new Vector3(a + 0.9f * random.NextFloat(), 0.2f, b + 0.9f * random.NextFloat());
                    if ((center - new Vector3(4f, 0.2f, 0f)).Length() > 0.9f)
                    {
                        if (chooseMat < 0.7)
                        {
                            Color randomColor = (VectorEx.Random() * VectorEx.Random() * 255f).ToColor();
                            AllHittable.Hittables.Add(new Sphere(center, 0.2f, new Lambertian(randomColor)));
                        }else if (chooseMat < 0.9f)
                        {
                            Color randomColor = (VectorEx.Random(0.5f, 1.0f) * 255f).ToColor();
                            var fuzz = random.NextFloat(0, 0.5f);
                            AllHittable.Hittables.Add(new Sphere(center, 0.2f, new MetalMaterial(randomColor, fuzz)));
                        }
                        else
                        {
                            AllHittable.Hittables.Add(new Sphere(center, 0.2f, new DielectricMaterial(1.5f)));
                        }
                    }
                }
            }
            
            AllHittable.Hittables.Add(
                new Sphere(new Vector3(0, 1, 0), 1.0f, new DielectricMaterial(1.5f)));
            
            AllHittable.Hittables.Add(
                new Sphere(new Vector3(-3, 1, 0), 1.0f, 
                    new Lambertian(Color.FromArgb(
                        (int)(255 * 0.4f), 
                        (int)(255f * 0.2f), 
                        (int)(255 * 0.1f)))));
            
            AllHittable.Hittables.Add(new Sphere(new Vector3(3, 1, 0), 1.0f, 
                new MetalMaterial(Color.FromArgb(
                    (int)(255 * 0.7f), 
                    (int)(255*0.6f), 
                    (int)(255 * 0.5f)))));
            
            
            return AllHittable;
        }

        public static Hittable GetTestScene()
        {
            HittableList AllHittable = new HittableList();
            
            var Color1 = Color.FromArgb((int) (255 * 0.7f), (int) (255 * 0.3f), (int) (255 * 0.3f));
            var Color2 = Color.FromArgb((int)(255 * 0.8f), (int)(255 * 0.8f), (int)(255 * 0.8f));
            var Color3 = Color.FromArgb((int)(255 * 0.8f), (int)(255 * 0.6f), (int)(255 * 0.2f));
            var Color4 = Color.FromArgb((int)(255 * 0.8f), (int)(255 * 0.8f), (int)(255 * 0f));
            
            AllHittable.Hittables.AddRange(new []
            {
                new Sphere(new Vector3(0, 0, -1), 0.5f, new Lambertian(Color1)),
                new Sphere(new Vector3(-1, 0, -1f), -0.49f, new DielectricMaterial(1.5f)),
                new Sphere(new Vector3(-1, 0, -1f), 0.5f, new DielectricMaterial(1.5f)),
                new Sphere(new Vector3(1, 0, -1f), 0.5f, new MetalMaterial(Color3, 0.1f)),
                
                new Sphere(new Vector3(0, -100.5f, -1), 100f, new Lambertian(Color4)),
            });

            
            return AllHittable;
        }
    }
}