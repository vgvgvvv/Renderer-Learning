using System;
using SDL2;

namespace SoftwareRenderer.Core
{
    public class RenderDevice
    {
        public IntPtr Renderer => Application.GetInstance().Renderer;
        
        public void Update()
        {
            SDL.SDL_SetRenderDrawColor(Renderer, 0, 0, 0, 0);
            SDL.SDL_RenderClear(Renderer);
            
            
            
            for (int x = 0; x < Application.WINDOW_WIDTH; x++)
            {
                for (int y = 0; y < Application.WINDOW_HEIGHT; y++)
                {
                    var R = (float)x / Application.WINDOW_WIDTH * 255f;
                    var G = ((float)(Application.WINDOW_HEIGHT - y) / Application.WINDOW_HEIGHT) * 255f;
                    SDL.SDL_SetRenderDrawColor(Renderer, (byte)R, (byte)G, 0, 255);
                    SDL.SDL_RenderDrawPoint(Renderer, x, y);
                }
            }
            
            
            SDL.SDL_RenderPresent(Renderer);
        }
    }
}