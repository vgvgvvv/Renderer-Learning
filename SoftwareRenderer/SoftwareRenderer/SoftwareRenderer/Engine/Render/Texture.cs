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
        public readonly Color[,] Pixels;
        public readonly int Width;
        public readonly int Height;

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
                Mathf.Min((int)(Width * u), Width-1), 
                Mathf.Min((int)(Height * v), Height-1)];
            return color;
        }
    }
}
