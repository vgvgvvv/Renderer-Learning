using System;
using MathLib;
using SDL2;
using SoftwareRenderer.Component;
using SoftwareRenderer.Core;
using SoftwareRenderer.Materials;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Scene
{
    public class TestWorld : World
    {

        public TestWorld()
        {
        }

        public override void Awake()
        {
            base.Awake();
            
            var camera = WorldObject.Create<Camera>(this, new Vector3(0, 0, -10));

            var cube1 = WorldObject.Create<CubeRenderer>(this, new Vector3(1, 0, 1));
            cube1.Transform.scale = Vector3.one * 2;
            cube1.Mat = new TextureMaterial("test.jpg");
            
            var cube2 = WorldObject.Create<CubeRenderer>(this, new Vector3(-1, 0, 1));
            cube2.Transform.scale = Vector3.one * 1;
            cube2.Mat = new TextureMaterial("test.jpg");

            cube1.OnUpdate += () =>
            {
                cube1.Transform.rotation = Quaternion.Euler(1, 1, 0) * cube1.Transform.rotation;
            };
            
            cube2.OnUpdate += () =>
            {
                cube2.Transform.rotation = Quaternion.Euler(1, 1, 0) * cube2.Transform.rotation;
            };
            
            var inputSystem = Application.Get().InputSystem;
            inputSystem.OnInputEvent += delegate(SDL.SDL_Event e)
            {
                switch (e.key.keysym.sym)
                {
                    case SDL.SDL_Keycode.SDLK_q:
                    {
                        camera.Transform.position += Vector3.up;
                        Console.WriteLine("camera position:" + camera.Transform.position);
                        break;
                    }
                    case SDL.SDL_Keycode.SDLK_e:
                    {
                        camera.Transform.position += Vector3.down;
                        Console.WriteLine("camera position:" + camera.Transform.position);
                        break;
                    }
                    case SDL.SDL_Keycode.SDLK_w:
                    {
                        camera.Transform.position += Vector3.forward;
                        Console.WriteLine("camera position:" + camera.Transform.position);
                        break;
                    }
                    case SDL.SDL_Keycode.SDLK_s:
                    {
                        camera.Transform.position += Vector3.back;
                        Console.WriteLine("camera position:" + camera.Transform.position);
                        break;
                    }
                    case SDL.SDL_Keycode.SDLK_a:
                    {
                        camera.Transform.position += Vector3.left;
                        Console.WriteLine("camera position:" + camera.Transform.position);
                        break;
                    }
                    case SDL.SDL_Keycode.SDLK_d:
                    {
                        camera.Transform.position += Vector3.right;
                        Console.WriteLine("camera position:" + camera.Transform.position);
                        break;
                    }

                    case SDL.SDL_Keycode.SDLK_j:
                    {
                        camera.Transform.rotation = Quaternion.Euler(0, -10, 0) * camera.Transform.rotation;
                        break;
                    }
                    case SDL.SDL_Keycode.SDLK_l:
                    {
                        camera.Transform.rotation = Quaternion.Euler(0, 10, 0) * camera.Transform.rotation;
                        break;
                    }
                    case SDL.SDL_Keycode.SDLK_i:
                    {
                        camera.Transform.rotation = Quaternion.Euler(10, 0, 0) * camera.Transform.rotation;
                        break;
                    }
                    case SDL.SDL_Keycode.SDLK_k:
                    {
                        camera.Transform.rotation = Quaternion.Euler(-10, 0, 0) * camera.Transform.rotation;
                        break;
                    }
                } 
                
            };
        }
    }
}