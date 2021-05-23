using System;
using System.Collections.Generic;
using MathLib;

namespace SoftwareRenderer.Render
{
    public enum RenderMode
    {
        /// <summary>
        /// 线框模式
        /// </summary>
        Wireframe,
        /// <summary>
        /// 纹理
        /// </summary>
        Filled,
        /// <summary>
        /// 顶点色
        /// </summary>
        WireframeAndFilled
    }
    
    public class SoftwareRenderDevice
    {
        public Color[,] FrameBuffer { get; }
        public float[,] ZBuffer { get; }
        public int Width { get; }
        public int Height { get; }

        public Color ClearColor { get; set; } = Color.black;

        public RenderMode RenderMode { get; set; }= RenderMode.Filled;
        
        public Matrix4x4 ViewMat { get; internal set; }
        public Matrix4x4 ProjectorMat { get; internal set; }

        /// <summary>
        /// 绘制任务列表
        /// </summary>
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

        public void Draw2DLine(Vertex v1, Vertex v2, Color? color = null)
        {
            Draw2DLine((int)v1.Position.x, (int)v1.Position.y, v1.Position.z, color ?? v1.Color, 
                (int)v2.Position.x, (int)v2.Position.y, v2.Position.z, color ?? v2.Color);
        }

        /// <summary>
        /// 基本思路是把任意三角形拆分成上下两个，然后逐个进行扫描线填充
        /// </summary>
        /// <param name="v1">顶点1信息</param>
        /// <param name="sp1">屏幕位置</param>
        /// <param name="v2">顶点2信息</param>
        /// <param name="sp2">屏幕位置</param>
        /// <param name="v3">顶点3信息</param>
        /// <param name="sp3">屏幕位置</param>
        public void Draw2DTriangle(Vertex v1, Vertex v2, Vertex v3, Material mat)
        {
            // 绘制上三角形
            void DrawDownTriangle(Vertex v1, Vertex v2, Vertex buttom)
            {
                var left = v1;
                var right = v2;
                if (left.Position.x > right.Position.x)
                {
                    Utility.Swap(ref left, ref right);
                }
                var targetY = buttom.Position.y;
                for (float y = left.Position.y; y >= targetY; y -= 0.5f)
                {
                    int yIndex = Mathf.RoundToInt(y);
                    if (yIndex < 0 || yIndex >= Height)
                    {
                        continue;
                    }

                    var lerpFactor = (targetY - y) / (targetY - left.Position.y);
                    Vertex vl = Vertex.Lerp(left, buttom, 1.0f - lerpFactor);
                    Vertex vr = Vertex.Lerp(right, buttom, 1.0f - lerpFactor);
                    
                    ScanlineFile(vl, vr, yIndex);
                }
            }

            // 绘制下三角形
            void DrawUpTriangle(Vertex v1, Vertex v2, Vertex top)
            {
                var left = v1;
                var right = v2;
                if (left.Position.x > right.Position.x)
                {
                    Utility.Swap(ref left, ref right);
                }
                var targetY = top.Position.y;
                for (float y = left.Position.y; y <= top.Position.y; y += 0.5f)
                {
                    int yIndex = Mathf.RoundToInt(y);
                    if (yIndex < 0 || yIndex >= Height)
                    {
                        continue;
                    }
                    
                    var lerpFactor = (targetY - y) / (targetY - left.Position.y);
                    Vertex vl = Vertex.Lerp(left, top, 1.0f - lerpFactor);
                    Vertex vr = Vertex.Lerp(right, top, 1.0f - lerpFactor);
                    
                    ScanlineFile(vl, vr, yIndex);
                    
                }
            }
            
            // 扫描线算法
            void ScanlineFile(Vertex left, Vertex right, int yIndex)
            {
                float dx = right.Position.x - left.Position.x;
                for (float x = left.Position.x; x <= right.Position.x; x += 0.5f)
                {
                    int xIndex = (int)(x + 0.5f);
                    if (xIndex >= 0 && xIndex < Width)
                    {
                        float lerpFactor = 0;
                        if (dx != 0)
                        {
                            lerpFactor = (x - left.Position.x) / dx;
                        }

                        var lerpedVertex = Vertex.Lerp(left, right, lerpFactor);

                        BaseFragmentIn fragmentIn = new BaseFragmentIn();
                        fragmentIn.Color = lerpedVertex.Color;
                        fragmentIn.Normal = lerpedVertex.Normal;
                        fragmentIn.UV = lerpedVertex.UV;
                        fragmentIn.Position = lerpedVertex.Position;
                        
                        var color = mat.Shader.Fragment(fragmentIn);
                        Draw2DPoint(xIndex, yIndex, lerpedVertex.Position.z, color);
                    }
                    
                }
            }

            if (Mathf.Approximately(v1.Position.y, v2.Position.y) && 
                Mathf.Approximately(v1.Position.y, v3.Position.y) && 
                Mathf.Approximately(v2.Position.y, v3.Position.y))
            {
                return;
            }
            
            //
            if (Mathf.Approximately(v1.Position.y, v2.Position.y))
            {
                if (v1.Position.y < v3.Position.y)
                {
                    // 尖头在上面
                    DrawUpTriangle(v1, v2, v3);
                }
                else
                {
                    // 尖头在下面
                    DrawDownTriangle(v1, v2, v3);
                }
            }
            else if (Mathf.Approximately(v1.Position.y, v3.Position.y))
            {
                if (v1.Position.y < v2.Position.y)
                {
                    DrawUpTriangle(v1, v3, v2);
                }
                else
                {
                    DrawDownTriangle(v1, v3, v2);
                }
            }
            else if (Mathf.Approximately(v2.Position.y, v3.Position.y))
            {
                if (v2.Position.y < v1.Position.y)
                {
                    DrawUpTriangle(v2, v3, v1);
                }
                else
                {
                    DrawDownTriangle(v2, v3, v1);
                }
            }
            else
            {
                // 拆分三角形
                Vertex top;
                Vertex mid;
                Vertex buttom;

                if (v1.Position.y > v2.Position.y && v1.Position.y > v3.Position.y)
                {
                    top = v1;
                    if (v2.Position.y > v3.Position.y)
                    {
                        mid = v2;
                        buttom = v3;
                    }
                    else
                    {
                        mid = v3;
                        buttom = v2;
                    }
                }
                else if (v2.Position.y > v1.Position.y && v2.Position.y > v3.Position.y)
                {
                    top = v2;
                    if (v1.Position.y > v3.Position.y)
                    {
                        mid = v1;
                        buttom = v3;
                    }
                    else
                    {
                        mid = v3;
                        buttom = v1;
                    }
                }
                else if (v3.Position.y > v1.Position.y && v3.Position.y > v2.Position.y)
                {
                    top = v3;
                    if (v1.Position.y > v2.Position.y)
                    {
                        mid = v1;
                        buttom = v2;
                    }
                    else
                    {
                        mid = v2;
                        buttom = v1;
                    }
                }else
                {
                    return;
                }

                var lerpfactor = (top.Position.y - mid.Position.y) / (top.Position.y - buttom.Position.y);
                var anotherMid = Vertex.Lerp(top, buttom, lerpfactor);
                
                DrawUpTriangle(mid, anotherMid, top);
                DrawDownTriangle(mid, anotherMid, buttom);

            }
        }
        
        public void Draw3DLine(Vertex v1, Vertex v2)
        {

            v1.ApplyTransform(ViewMat);
            v2.ApplyTransform(ViewMat);
            v1.ApplyTransform(ProjectorMat);
            v2.ApplyTransform(ProjectorMat);

            var sp1 = TransformToScreen(v1);
            var sp2 = TransformToScreen(v2);

            v1.Position = sp1;
            v2.Position = sp2;
            
            if (NeedCVVClip(v1) || NeedCVVClip(v2))
            {
                return;
            }

            Draw2DLine(v1, v2);
        }
        
        /// <summary>
        /// 绘制三角形
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        public void Draw3DTriangle(Vertex v1, Vertex v2, Vertex v3, Material material)
        {

            if (RenderMode == RenderMode.Wireframe || 
                RenderMode == RenderMode.WireframeAndFilled)
            {
                Draw2DLine(v1, v2);
                Draw2DLine(v2, v3);
                Draw2DLine(v3, v1);
            }
            if(RenderMode == RenderMode.Filled || 
               RenderMode == RenderMode.WireframeAndFilled)
            {
                Draw2DTriangle(v1, v2, v3, material);
            }
            
        }
        
        #region Misc

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
                    new Vertex(){Position = new Vector3(x, 0, -10), Color = Color.gray}, 
                    new Vertex(){Position = new Vector3(x, 0, 10), Color = Color.gray});
            }
            
            for (int z = -10; z < 10; z++)
            {
                Draw3DLine(
                    new Vertex(){Position = new Vector3(-10, 0, z), Color = Color.gray}, 
                    new Vertex(){Position = new Vector3(10, 0, z), Color = Color.gray});
            }
        }

        #endregion

        #endregion

        private Vector3 TransformToScreen(Vertex vertex)
        {
            Vector3 pos = new Vector3();
            pos.x = (vertex.Position.x + 1) * 0.5f * Width;
            pos.y = (1 - vertex.Position.y) * 0.5f * Height;
            pos.z = vertex.Position.z;
            return pos;
        }

        private bool NeedCVVClip(Vertex v)
        {
            var p = v.Position;
            if (p.x > 1 || p.x < -1 || p.y > 1 || p.y < -1 || p.z > 1.1 || p.z < 0)
            {
                return true;
            }

            return false;
        }
        
        private bool BackfaceCulling(Vertex p1, Vertex p2, Vertex p3)
        {
            if (RenderMode == RenderMode.Wireframe)
            {
                return true;
            }
            else
            {
                var v1 = p2.Position - p1.Position;
                var v2 = p3.Position - p2.Position;
                var normal = Vector3.Cross(v1, v2);
                var viewDir = p2.Position - Vector3.zero;
                if(Vector3.Dot(normal, viewDir) > 0)
                {
                    return true;
                }
            }
            return false;
        }

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

            Draw2DLine(Width / 2, 0, 1, Color.green, Width / 2,  Height, 1, Color.red);
            Draw2DLine(0, Height / 2, 1, Color.green, Width,  Height / 2, 1, Color.red);

            // DrawGrid();
            
            // DrawUV();

            // Draw3DLine(new Vertex(new Vector3(0, 1, 0)), new Vertex(new Vector3(0, 0, 0)));

            // 无效的index
            bool[] invalidIndex = new bool[1024];
            foreach (var command in drawCommands)
            {
                Array.Fill(invalidIndex, false);
                for (var i = 0; i < command.Vertexs.Length; i++)
                {
                    var v = command.Vertexs[i];
                    BaseVertexIn baseVertexIn = new BaseVertexIn();
                    baseVertexIn.Position = v.Position;
                    baseVertexIn.Normal = v.Normal;
                    baseVertexIn.VertexColor = v.Color;
                    var vertexOut = command.Mat.Shader.Vertex(baseVertexIn);
                    
                    v.Position = vertexOut.Position;
                    v.Normal = vertexOut.Normal;
                    v.Color = vertexOut.Color;
                    
                    // View转换
                    v.ApplyTransform(ViewMat);
                    command.Vertexs[i] = v;
                    
                }

                // 背隐剔除
                for (var i = 0; i < command.Indexs.Length; i++)
                {
                    var indexGroup = command.Indexs[i];
                    var v1 = command.Vertexs[(int) indexGroup[0]];
                    var v2 = command.Vertexs[(int) indexGroup[1]];
                    var v3 = command.Vertexs[(int) indexGroup[2]];
                    if (!BackfaceCulling(v1, v2, v3))
                    {
                        invalidIndex[i] = true;
                    }
                }
                
                // 投影变换
                for (var i = 0; i < command.Vertexs.Length; i++)
                {
                    var v = command.Vertexs[i];
                    v.ApplyTransform(ProjectorMat);
                    if (NeedCVVClip(v))
                    {
                        v.NeedClip = true;
                    }
                    else
                    {
                        v.Position = TransformToScreen(v);
                        command.Vertexs[i] = v;
                    }
                    
                }

                // 绘制三角形
                for (var i = 0; i < command.Indexs.Length; i++)
                {
                    if (invalidIndex[i])
                    {
                        continue;
                    }

                    var indexGroup = command.Indexs[i];
                    var v1 = command.Vertexs[(int) indexGroup[0]];
                    var v2 = command.Vertexs[(int) indexGroup[1]];
                    var v3 = command.Vertexs[(int) indexGroup[2]];
                    if (v1.NeedClip || v2.NeedClip || v3.NeedClip)
                    {
                        continue;
                    }
                    
                    Draw3DTriangle(v1, v2, v3, command.Mat);
                }
                
            }
            drawCommands.Clear();

            return FrameBuffer;
        }

    }
}
