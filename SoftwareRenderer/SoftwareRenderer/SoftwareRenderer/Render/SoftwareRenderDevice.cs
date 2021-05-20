using System.Drawing;
using System.Numerics;

namespace SoftwareRenderer.Render
{
    public class SoftwareRenderDevice
    {
        public Color[,] FrameBuffer { get; }
        public float[,] ZBuffer { get; }
        public int Width { get; }
        public int Height { get; }

        public Color ClearColor { get; set; } = Color.Black;

        public Matrix4x4 ViewMat { get; set; }
        public Matrix4x4 ProjectorMat { get; set; }


        public SoftwareRenderDevice(int width, int height)
        {
            Width = width;
            Height = height;
            FrameBuffer = new Color[width, height];
            ZBuffer = new float[width,height];
        }


        #region 绘制函数


        public void Draw2DPoint(int x, int y, Color color)
        {
            if (x >= 0 && x < Width && y >= 0 && y < Height)
            {
                FrameBuffer[x, y] = color;
            }
        }

        /// <summary>
        /// Bresenham 画直线算法
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="color"></param>
        public void Draw2DLine(int x1, int y1, int x2, int y2, Color color)
        {
            int x, y, rem = 0;
            if (x1 == x2 && y1 == y2)
            {
                Draw2DPoint(x1, y1, color);
            }else if (x1 == x2)
            {
                int inc = y1 <= y2 ? 1 : -1;
                for (y = y1; y != y2; y += inc)
                {
                    Draw2DPoint(x1, y, color);
                }
            }else if (y1 == y2)
            {
                int inc = x1 <= x2 ? 1 : -1;
                for (x = x1; x != x2; x += inc)
                {
                    Draw2DPoint(x, y1, color);
                }
            }
            else
            {
                int dx = x1 <= x2 ? x2 - x1 : x1 - x2;
                int dy = y1 <= y2 ? y2 - y1 : y1 - y2;
                if (dx >= dy)
                {
                    if (x2 < x1)
                    {
                        x = x1; x1 = x2; x2 = x;
                        y = y1; y1 = y2; y2 = y;
                    }

                    for (x = x1, y = y1; x <= x2; x++)
                    {
                        Draw2DPoint(x, y, color);
                        rem += dy;
                        if (rem > dx)
                        {
                            rem -= dx;
                            y += y2 >= y1 ? 1 : -1;
                            Draw2DPoint(x, y, color);
                        }
                    }
                }
                else
                {
                    if (y2 < y1)
                    {
                        x = x1; x1 = x2; x2 = x;
                        y = y1; y1 = y2; y2 = y;
                    }

                    for (x = x1, y = y1; y <= y2; y++)
                    {
                        Draw2DPoint(x, y, color);
                        rem += dx;
                        if (rem > dy)
                        {
                            rem -= dy;
                            x += x2 >= x1 ? 1 : -1;
                            Draw2DPoint(x, y, color);
                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// 绘制project之前的三角形
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        public void DrawTriangle(Vector3 p1, Vector3 p2, Vector3 p3, Matrix4x4 m, Matrix4x4 v, Matrix4x4 p)
        {

        }

        private void DrawUV()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    var R = (float)x / Width * 255;
                    var G = (float)y / Height * 255;
                    Draw2DPoint(x, y, Color.FromArgb((int)R, (int)G, 0));
                }
            }
        }

        #endregion

        #region Transform

        // public Vector3 TransformModel(Transform transform, Vector3 pos)
        // {
        //     Matrix4x4 tranMat = Matrix4x4.Identity;
        //     
        //    
        // }
        //
        // public Vector3 TransformView(Transform transform, Vector3 pos)
        // {
        //
        // }
        //
        // public Vector3 TransformProjector(Vector3 pos)
        // {
        //
        // }

        #endregion

        public void FrameClear()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    FrameBuffer[x, y] = ClearColor;
                    ZBuffer[x, y] = 0;
                }
            }

        }

        public Color[,] Render()
        {
            FrameClear();


            Draw2DLine(0, Height, Width, 0, Color.Red);

            // DrawUV();


            return FrameBuffer;
        }

        

        
    }
}
