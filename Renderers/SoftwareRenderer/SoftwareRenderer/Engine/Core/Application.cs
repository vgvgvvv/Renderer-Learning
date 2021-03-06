using System;
using System.Threading.Tasks;
using SDL2;
using UniLua;

namespace SoftwareRenderer.Core
{
    public class Application
    {
        private static Application Instance;

        public static Application Get()
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
        private DateTime lastUpdateFpsTime = DateTime.Now;
        private int frameCount = 0;


        public InputSystem InputSystem{ get; private set; }
        public IRenderer RenderSystem{ get; private set; }
        public LuaManager LuaSystem { get; private set; }
        public World World{ get; private set; }

        private bool shouldQuit = false;

        public void Run()
        {
            World.Awake();
            while (!shouldQuit)
            {
                Update();
                if (DateTime.Now - lastUpdateFpsTime > TimeSpan.FromSeconds(1))
                {
                    SDL.SDL_SetWindowTitle(Window, "fps : " + frameCount);
                    frameCount = 0;
                    lastUpdateFpsTime = DateTime.Now;
                }
                frameCount++;
            }
        }
        
        public void Init(World scene = null)
        {
            World = scene;
            if (World == null)
            {
                World = new World();
            }
            
            LuaSystem = new LuaManager();
            LuaSystem.Init();
            
            World.Init();
            
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

            InputSystem = new InputSystem();
            InputSystem.OnInputEvent += inputEvent =>
            {
                if (inputEvent.type == SDL.SDL_EventType.SDL_QUIT)
                {
                    shouldQuit = true;
                }
            };
            RenderSystem = new SDLRenderer(Renderer, WINDOW_WIDTH, WINDOW_HEIGHT);
            RenderSystem.Init();
            
        }

        public void Uninit()
        {
            RenderSystem.Uninit();
            SDL.SDL_DestroyRenderer(Renderer);
            SDL.SDL_DestroyWindow(Window);
            
            SDL.SDL_Quit();
        }
        
        private void Update()
        {
            World.Update();
            World.BeforeRender();
            RenderSystem.Update();
            InputSystem.Update();
        }

        
    }
}