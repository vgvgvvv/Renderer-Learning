using System;
using System.Runtime.InteropServices;
using SDL2;

namespace SoftwareRenderer
{
    class Program
    {
        private static int WINDOW_WIDTH = 1280;
        private static int WINDOW_HEIGHT = 720;
        
        static void Main(string[] args)
        {
            if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO) < 0)
            {
                Console.WriteLine("Unable to initialize SDL. Error : {0}", SDL.SDL_GetError());
            }

            IntPtr window;
            IntPtr renderer;
            SDL.SDL_CreateWindowAndRenderer(
                WINDOW_WIDTH, WINDOW_HEIGHT, 
                SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE, out window, out renderer);

            if (window == IntPtr.Zero || renderer == IntPtr.Zero)
            {
                Console.WriteLine("cannot create window, Error : {0}", SDL.SDL_GetError());
            }

            SDL.SDL_SetRenderDrawColor(renderer, 0, 0, 0, 0);
            SDL.SDL_RenderClear(renderer);
            SDL.SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255);
            for (int i = 0; i < WINDOW_WIDTH; i++)
            {
                SDL.SDL_RenderDrawPoint(renderer, i, i);
            }
            SDL.SDL_RenderPresent(renderer);
            
            SDL.SDL_Event e;
            bool quit = false;

            while (!quit)
            {
                while (SDL.SDL_PollEvent(out e) != 0)
                {
                    switch (e.type)
                    {
                        case SDL.SDL_EventType.SDL_QUIT:
                            quit = true;
                            break;
                    }
                }
            }
            
            SDL.SDL_DestroyRenderer(renderer);
            SDL.SDL_DestroyWindow(window);
            
            SDL.SDL_Quit();
            
        }
    }
}