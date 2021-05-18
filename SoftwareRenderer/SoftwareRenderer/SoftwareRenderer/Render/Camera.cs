using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
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

        public int FOV = 60;
        public float Aspect = 16.0f/9;
        public Vector3 Forward =>  * -Vector3.UnitZ;

        public override void Update()
        {
            
        }

    }
}
