using System.Drawing;
using MathLib;
using Color = MathLib.Color;


namespace SoftwareRenderer.Render
{
    /// <summary>
    /// 纹理过滤模式
    /// </summary>
    public enum TextureFilterMode
    {
        /// <summary>
        /// 点采样
        /// </summary>
        Point,
        /// <summary>
        /// 双线性采样
        /// </summary>
        Bilinear
    }
    
    public class Texture
    {
        public Color[,] Pixels { get; }
        public int Width { get; }
        public int Height { get; }

        public TextureFilterMode FilterMode { get; set; } = TextureFilterMode.Bilinear;

        public Texture(int width, int height)
        {
            Width = width;
            Height = height;
            Pixels = new Color[width,height];
        }

        public static Texture LoadFromFile(string fileName)
        {
            Bitmap bitmap = new Bitmap(fileName);
            var texture = new Texture(bitmap.Width, bitmap.Height);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    var color = bitmap.GetPixel(x, y);
                    texture.Pixels[x, y] = new Color(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
                }
            }

            return texture;
        }

        public Color Sample(float u, float v)
        {
            Color color = Pixels[
                Mathf.Clamp((int)(Width * u), 0, Width-1), 
                Mathf.Clamp((int)(Height * v), 0, Height-1)];
            return color;
        }
    }
}
