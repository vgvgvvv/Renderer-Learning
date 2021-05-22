using System;
using System.Collections.Generic;
using MathLib;
using SoftwareRenderer.Core;

namespace SoftwareRenderer.Render
{
    public class Camera : Behavior
    {
        public static List<Camera> Cameras = new List<Camera>();

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
        public float Aspect = 16.0f / 9;
        public float NearZ = 0.1f;
        public float FarZ = 100f;
        public Vector3 Forward => Vector3.forward;

        public override void Update()
        {
            
        }

        public override void BeforeRender()
        {
            base.BeforeRender();
            Application.Get().RenderSystem.SetViewMat(GetViewMatrix());
            Application.Get().RenderSystem.SetProjectorMat(GetPerspectiveProjectionMatrix());
        }

        public Matrix4x4 GetViewMatrix()
        {
            Vector3 right = Vector3.Cross(Vector3.up, Vector3.forward);
            var pos = Transform.position;

            Matrix4x4 t = new Matrix4x4(
                1, 0, 0, -pos.x,
                0, 1, 0, -pos.y,
                0, 0, 1, -pos.z,
                0, 0, 0, 1);

            Matrix4x4 r = Matrix4x4.Rotate(Transform.rotation);

            return t * r;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Matrix4x4 GetPerspectiveProjectionMatrix()
        {
            return Matrix4x4.Perspective(FOV, Aspect, NearZ, FarZ);
        }

        public Matrix4x4 GetOrthoProjectionMatrix()
        {
            throw new NotImplementedException();
            //Matrix4x4.Ortho()
        }
    }
}
