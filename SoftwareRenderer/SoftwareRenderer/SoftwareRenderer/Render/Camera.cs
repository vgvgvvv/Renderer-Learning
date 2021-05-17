using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SoftwareRenderer.Render
{
    public class Camera : WorldObject
    {
        public List<Camera> Cameras = new List<Camera>();
        public Camera main
        {
            get
            {
                if (Cameras.Count == 0)
                {
                    Cameras.Add(new Camera());
                }

                return Cameras[0];
            }
        }

    }
}
