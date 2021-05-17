using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SoftwareRenderer.Render
{
    public class Texture
    {
        public Color[,] Pixels { get; }
        public int Width { get; }
        public int Height { get; }

        public Texture(int width, int height)
        {
            Width = width;
            Height = height;
            Pixels = new Color[width,height];
        }

    }
}
