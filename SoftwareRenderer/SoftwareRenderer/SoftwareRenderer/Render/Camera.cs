using System.Collections.Generic;
using MathLib;

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

        public Matrix4x4 GetViewMatrix()
        {
            Vector3 right = Vector3.Cross(Vector3.up, Vector3.forward);
            var pos = Transform.position;

            Matrix4x4 t = new Matrix4x4(
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 0,
                -pos.x, -pos.y, -pos.z, 1);

            Matrix4x4 r = Matrix4x4.Rotate(Transform.rotation);

            return t * r;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Matrix4x4 GetProjectionMatrix()
        {
            Matrix4x4 p = Matrix4x4.zero;
            p[0, 0] = (float)(1 / (System.Math.Tan(FOV * 0.5f) * Aspect));
            p[1, 1] = (float)(1 / System.Math.Tan(FOV * 0.5f));
            p[2, 2] = FarZ / (FarZ - NearZ);
            p[2, 3] = 1f;
            p[3, 2] = (NearZ * FarZ) / (NearZ - FarZ);
            return p;
            
        }
    }
}
