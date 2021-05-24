using System;
using System.Runtime.InteropServices;
using MathLib;
using SDL2;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Core
{
    public class SDLRenderer : IRenderer
    {
        public IntPtr Renderer { get; }
        private IntPtr RenderTargetTexture;
        private byte[] PixelBytes;
        private IntPtr PixelBytesIntPtr;
        public int Width { get; }
        public int Height { get; }

        private SoftwareRenderDevice device;

        public SoftwareRenderDevice Device => device;

        public SDLRenderer(IntPtr renderer, int width, int height)
        {
            Renderer = renderer;
            Width = width;
            Height = height;
            RenderTargetTexture = SDL.SDL_CreateTexture(Renderer, SDL.SDL_PIXELFORMAT_RGBA8888,
                (int) SDL.SDL_TextureAccess.SDL_TEXTUREACCESS_TARGET, width, height);
            PixelBytes = new byte[Width * Height * 4];
            PixelBytesIntPtr = Marshal.UnsafeAddrOfPinnedArrayElement(PixelBytes, Width * Height * 4);
            device = new SoftwareRenderDevice(width, height);

        }

        public void PushDrawCommand(DrawCommand command)
        {
            device.PushDrawCommand(command);
        }

        public void SetViewMat(Matrix4x4 mat)
        {
            Device.ViewMat = mat;
        }

        public void SetProjectorMat(Matrix4x4 mat)
        {
            Device.ProjectorMat = mat;
        }

        public void Init()
        {
            
        }
        
        public void Update()
        {
            SDL.SDL_SetRenderDrawColor(Renderer, 0, 0, 0, 0);
            SDL.SDL_RenderClear(Renderer);
            
            // Console.WriteLine("!!!");
            
            SDL.SDL_SetRenderTarget(Renderer, RenderTargetTexture);
            var frameBuffer = device.Render();
            var lastColor = Color.black;
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    var color = frameBuffer[Width - x - 1, y];
                    if (Math.Abs(color.r - lastColor.r) > 0.0001f || 
                        Math.Abs(color.g - lastColor.g) > 0.0001f || 
                        Math.Abs(color.b - lastColor.b) > 0.0001f || 
                        Math.Abs(color.a - lastColor.a) > 0.0001f)
                    {
                        SDL.SDL_SetRenderDrawColor(Renderer, (byte)(color.r * 255), (byte)(color.g * 255), (byte)(color.b * 255), 255);
                        lastColor = color;
                    }
                    
                    SDL.SDL_RenderDrawPoint(Renderer, x, y);
                    
                    // PixelBytes[y * Width + x] = (byte) (color.r * 255);
                    // PixelBytes[y * Width + x + 1] = (byte) (color.g * 255);
                    // PixelBytes[y * Width + x + 2] = (byte) (color.b * 255);
                    // PixelBytes[y * Width + x + 3] = (byte) 255;
                    
                    // PixelBytes[y * Width + x] = (byte) (1 * 255);
                    // PixelBytes[y * Width + x + 1] = (byte) (0 * 255);
                    // PixelBytes[y * Width + x + 2] = (byte) (0 * 255);
                    // PixelBytes[y * Width + x + 3] = (byte) 255;
                    
                }
            }
            // SDL.SDL_UpdateTexture(RenderTargetTexture, IntPtr.Zero,PixelBytesIntPtr, Width * IntPtr.Size);
            
            SDL.SDL_SetRenderTarget(Renderer, IntPtr.Zero);
            SDL.SDL_RenderCopy(Renderer, RenderTargetTexture, IntPtr.Zero, IntPtr.Zero);
            
            SDL.SDL_RenderPresent(Renderer);
        }

        public void Uninit()
        {
            SDL.SDL_DestroyTexture(RenderTargetTexture);
        }
    }
}