using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using SoftwareRenderer.Core;

namespace SoftwareRenderer.Render
{
    public class Camera : Behavior
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

        public override void Update()
        {
            var softwareDevice = Application.GetInstance().renderSystem.Device;
            softwareDevice.ViewTransform = Transform;
        }

    }
}
