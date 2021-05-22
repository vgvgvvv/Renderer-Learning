using System;
using SDL2;

namespace SoftwareRenderer.Core
{
    public class InputSystem
    {
        public event Action<SDL.SDL_Event> OnInputEvent;

        public void Update()
        {
            SDL.SDL_Event e;
            while (SDL.SDL_PollEvent(out e) != 0)
            {
                OnInputEvent?.Invoke(e);
            }
        }
    }
}