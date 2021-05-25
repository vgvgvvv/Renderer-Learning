using System;
using System.Collections.Generic;
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
        private uint[] PixelBytes;
        public readonly int Width;
        public readonly int Height;

        private SoftwareRenderDevice device;

        public SoftwareRenderDevice Device => device;

        public SDLRenderer(IntPtr renderer, int width, int height)
        {
            Renderer = renderer;
            Width = width;
            Height = height;
            RenderTargetTexture = SDL.SDL_CreateTexture(Renderer, SDL.SDL_PIXELFORMAT_RGBA8888,
                (int) SDL.SDL_TextureAccess.SDL_TEXTUREACCESS_TARGET, Width, Height);
            PixelBytes = new uint[Width * Height];
            device = new SoftwareRenderDevice(width, height);

        }

        public void PushDrawCommand(List<DrawCommand> commands)
        {
            device.PushDrawCommand(commands);
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
            
            SDL.SDL_SetRenderTarget(Renderer, RenderTargetTexture);
            var frameBuffer = device.Render();
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    var color = frameBuffer[Width - x - 1 + y * Width];

                    PixelBytes[x + y * Width] = 0x00000000 | 
                                                (uint)(color.r * 255) << 24 | 
                                                (uint)(color.g * 255) << 16 |
                                                (uint)(color.b * 255) << 8 |
                                                (uint)(color.a * 255);
                }
            }

            unsafe
            {
                fixed (uint* p = PixelBytes)
                {
                    IntPtr ptr = (IntPtr)p;
                    SDL.SDL_UpdateTexture(RenderTargetTexture, IntPtr.Zero, ptr, Width * sizeof(byte) * 4);
                }
            }
            
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