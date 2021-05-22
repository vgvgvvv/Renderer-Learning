using System;
using System.Collections.Generic;
using MathLib;

namespace SoftwareRenderer.Render
{
    public class SoftwareRenderDevice
    {
        public Color[,] FrameBuffer { get; }
        public float[,] ZBuffer { get; }
        public int Width { get; }
        public int Height { get; }

        public Color ClearColor { get; set; } = Color.black;

        public Matrix4x4 ViewMat { get; set; }
        public Matrix4x4 ProjectorMat { get; set; }

        private List<DrawCommand> drawCommands = new List<DrawCommand>();


        public SoftwareRenderDevice(int width, int height)
        {
            Width = width;
            Height = height;
            FrameBuffer = new Color[width, height];
            ZBuffer = new float[width,height];
        }


        #region 绘制函数

        // 0,0点平移到了中点
        public void Draw2DPoint(int x, int y, float depth, Color color)
        {
            x = x + Width / 2;
            y = y + Height / 2;
            if (x >= 0 && x < Width && y >= 0 && y < Height && ZBuffer[x, y] < depth)
            {
                FrameBuffer[x, y] = color;
                ZBuffer[x, y] = depth;
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
        public void Draw2DLine(int x1, int y1, float depth1, Color color1, int x2, int y2, float depth2, Color color2)
        {
            int x, y, rem = 0;
            if (x1 == x2 && y1 == y2)
            {
                Draw2DPoint(x1, y1, depth1, color1);
            }else if (x1 == x2)
            {
                int inc = y1 <= y2 ? 1 : -1;
                for (y = y1; y != y2; y += inc)
                {
                    var t = (float)(y2 - y) / (y2 - y1);
                    var depth = Mathf.Lerp(depth1, depth2, t);
                    var color = Color.Lerp(color1, color2, t);
                    Draw2DPoint(x1, y, depth, color);
                }
            }else if (y1 == y2)
            {
                int inc = x1 <= x2 ? 1 : -1;
                for (x = x1; x != x2; x += inc)
                {
                    var t = (float) (x2 - x) / (x2 - x1);
                    var depth = Mathf.Lerp(depth1, depth2, t);
                    var color = Color.Lerp(color1, color2, t);
                    Draw2DPoint(x, y1, depth, color);
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
                        var t = (float)(x2 - x) / (x2 - x1);
                        var depth = Mathf.Lerp(depth1, depth2, t);
                        var color = Color.Lerp(color1, color2, t);
                        Draw2DPoint(x, y, depth, color);
                        rem += dy;
                        if (rem > dx)
                        {
                            rem -= dx;
                            y += y2 >= y1 ? 1 : -1;
                            Draw2DPoint(x, y, depth, color);
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
                        var t = (float)(y2 - y) / (y2 - y1);
                        var depth = Mathf.Lerp(depth1, depth2, t);
                        var color = Color.Lerp(color1, color2, t);
                        Draw2DPoint(x, y, depth, color);
                        rem += dx;
                        if (rem > dy)
                        {
                            rem -= dy;
                            x += x2 >= x1 ? 1 : -1;
                            Draw2DPoint(x, y, depth, color);
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
        public void Draw3DTriangle(Vertex v1, Vertex v2, Vertex v3)
        {
            var p1 = v1.Position;
            p1 = ViewMat.MultiplyPoint(p1);
            p1 = ProjectorMat.MultiplyPoint(p1);

            var p2 = v2.Position;
            p2 = ViewMat.MultiplyPoint(p2);
            p2 = ProjectorMat.MultiplyPoint(p2);

            var p3 = v3.Position;
            p3 = ViewMat.MultiplyPoint(p3);
            p3 = ProjectorMat.MultiplyPoint(p3);

            Draw2DLine((int)(p1.x * Width), (int)(p1.y * Height), p1.z, v1.color, (int)(p2.x * Width), (int)(p2.y * Height), p2.z, v2.color);
            Draw2DLine((int)(p2.x * Width), (int)(p2.y * Height), p2.z, v2.color, (int)(p3.x * Width), (int)(p3.y * Height), p3.z, v3.color);
            Draw2DLine((int)(p3.x * Width), (int)(p3.y * Height), p3.z, v3.color, (int)(p1.x * Width), (int)(p1.y * Height), p1.z, v1.color);
        }

        public void Draw3DLine(Vertex v1, Vertex v2)
        {
            var p1 = v1.Position;
            p1 = ViewMat.MultiplyPoint(p1);
            p1 = ProjectorMat.MultiplyPoint(p1);

            var p2 = v2.Position;
            p2 = ViewMat.MultiplyPoint(p2);
            p2 = ProjectorMat.MultiplyPoint(p2);

            Draw2DLine((int)(p1.x * Width), (int)(p1.y * Height), p1.z, v1.color, (int)(p2.x * Width), (int)(p2.y * Height), p2.z, v2.color);
        }

        private void DrawUV()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    var R = (float)x / Width;
                    var G = (float)y / Height;
                    Draw2DPoint(x, y, 0, new Color(R, G, 0));
                }
            }
        }

        private void DrawGrid()
        {
            for (int x = -10; x < 10; x++)
            {
                Draw3DLine(
                    new Vertex(){Position = new Vector3(x, 0, -10), color = Color.gray}, 
                    new Vertex(){Position = new Vector3(x, 0, 10), color = Color.gray});
            }
            
            for (int z = -10; z < 10; z++)
            {
                Draw3DLine(
                    new Vertex(){Position = new Vector3(-10, 0, z), color = Color.gray}, 
                    new Vertex(){Position = new Vector3(10, 0, z), color = Color.gray});
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
                    ZBuffer[x, y] = -float.MaxValue;
                }
            }

        }

        public void PushDrawCommand(DrawCommand command)
        {
            drawCommands.Add(command);
        }

        public Color[,] Render()
        {
            FrameClear();


            Draw2DLine(0, -Height / 2, 1, Color.green, 0,  Height / 2, 1, Color.red);
            Draw2DLine(-Width / 2, 0, 1, Color.green, Width / 2,  0, 1, Color.red);

            // DrawGrid();
            
            // DrawUV();

            // Draw3DLine(new Vertex(new Vector3(0, 1, 0)), new Vertex(new Vector3(0, 0, 0)));


            foreach (var command in drawCommands)
            {
                foreach (var indexGroup in command.Indexs)
                {
                    Draw3DTriangle(
                        command.Vertexs[(int) indexGroup.x],
                        command.Vertexs[(int) indexGroup.y],
                        command.Vertexs[(int) indexGroup.z]);
                }
            }
            drawCommands.Clear();

            return FrameBuffer;
        }

        

        
    }
}
