using System;
using SDL2;

namespace SoftwareRenderer.Core
{
    public class Application
    {
        public static Application Instance;

        public static Application GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Application();
            }

            return Instance;
        }
        
        private Application(){}
        
        public static int WINDOW_WIDTH = 1280;
        public static int WINDOW_HEIGHT = 720;
        public IntPtr Window;
        public IntPtr Renderer;


        public InputSystem inputSystem;
        public SDLRenderer sdlRenderer;
        public World world;

        private bool shouldQuit = false;

        public void Run()
        {
            Init();
            while (!shouldQuit)
            {
                Update();
            }
            Uninit();
        }
        
        private void Init()
        {
            if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO) < 0)
            {
                Console.WriteLine("Unable to initialize SDL. Error : {0}", SDL.SDL_GetError());
            }

            SDL.SDL_CreateWindowAndRenderer(
                WINDOW_WIDTH, WINDOW_HEIGHT, 
                SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE, out Window, out Renderer);

            if (Window == IntPtr.Zero || Renderer == IntPtr.Zero)
            {
                Console.WriteLine("cannot create window, Error : {0}", SDL.SDL_GetError());
            }

            inputSystem = new InputSystem();
            inputSystem.OnInputEvent += inputEvent =>
            {
                if (inputEvent.type == SDL.SDL_EventType.SDL_QUIT)
                {
                    shouldQuit = true;
                }
            };
            sdlRenderer = new SDLRenderer(Renderer, WINDOW_WIDTH, WINDOW_HEIGHT);

        }

        private void Update()
        {
            world.Update();
            sdlRenderer.Update();
            inputSystem.Update();
        }
        
        private void Uninit()
        {
            SDL.SDL_DestroyRenderer(Renderer);
            SDL.SDL_DestroyWindow(Window);
            
            SDL.SDL_Quit();
        }
        
    }
}