using System.Collections.Generic;
using MathLib;

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
        public Vector3 Forward =>  Vector3.forward;

        public override void Update()
        {
            
        }

    }
}
