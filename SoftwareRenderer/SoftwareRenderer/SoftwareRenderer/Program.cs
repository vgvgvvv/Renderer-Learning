using System;
using SDL2;
using SoftwareRenderer.Core;
using SoftwareRenderer.Scene;

namespace SoftwareRenderer
{
    class Program
    {
        static void Main(string[] args)
        {

            Application.Get().Init();
            World world = new TestWorld();
            Application.Get().Run(world);
            Application.Get().Uninit();

        }
    }
}