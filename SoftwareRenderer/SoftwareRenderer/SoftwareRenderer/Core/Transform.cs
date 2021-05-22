using MathLib;

namespace SoftwareRenderer.Core
{
    public class Transform
    {
        public Vector3 position = Vector3.zero;
        public Vector3 scale = Vector3.one;

        public Vector3 eulerAngle
        {
            get
            {
                return rotation.eulerAngles;
            }
            set
            {
                rotation.eulerAngles = value;
            }
        }
        public Quaternion rotation = Quaternion.identity;

        public Matrix4x4 TransformMat =>
            Matrix4x4.Translate(position) * Matrix4x4.Scale(scale) * Matrix4x4.Rotate(rotation);
    }
}
