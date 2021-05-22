using System;
using System.Collections.Generic;
using System.Text;
using MathLib;

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

    }
}
