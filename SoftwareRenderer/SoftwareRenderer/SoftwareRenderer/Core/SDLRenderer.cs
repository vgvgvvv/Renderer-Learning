using System;
using MathLib;
using SDL2;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Core
{
    public class SDLRenderer : IRenderer
    {
        public IntPtr Renderer { get; }
        public int Width { get; }
        public int Height { get; }

        private SoftwareRenderDevice device;

        public SoftwareRenderDevice Device => device;

        public SDLRenderer(IntPtr renderer, int width, int height)
        {
            Renderer = renderer;
            Width = width;
            Height = height;
            device = new SoftwareRenderDevice(width, height);

        }

        public void Update()
        {
            SDL.SDL_SetRenderDrawColor(Renderer, 0, 0, 0, 0);
            SDL.SDL_RenderClear(Renderer);


            var frameBuffer = device.Render();
            var lastColor = Color.black;
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    var color = frameBuffer[x, Height - y - 1];
                    if (color != lastColor)
                    {
                        SDL.SDL_SetRenderDrawColor(Renderer, (byte)(color.r * 255), (byte)(color.g * 255), (byte)(color.b * 255), 255);
                        lastColor = color;
                    }
                    SDL.SDL_RenderDrawPoint(Renderer, x, y);
                    
                }
            }
            
            
            SDL.SDL_RenderPresent(Renderer);
        }
    }
}