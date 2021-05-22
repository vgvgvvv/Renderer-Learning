using System;
using System.Threading.Tasks.Dataflow;
using Common;
using MathLib;
using NUnit.Framework;
using SoftwareRenderer.Render;

namespace TestSoftRender
{
    public class TestMaths
    {
        [Test]
        public void NextPowerOfTwo()
        {
            int v = 51;
            v--;
            v |= v >> 1;
            v |= v >> 2;
            v |= v >> 4;
            v |= v >> 8;
            v |= v >> 16;
            v++;
            Console.Write(v);
        }

        [Test]
        public void TestSwap()
        {
            int[] a = new[] {1, 2, 3, 4};
            int[] b = new[] {5, 4, 3, 2, 1};
            Utility.Swap(ref a, ref b);
            Console.WriteLine(a.ConverToString());
            Console.WriteLine(b.ConverToString());
        }

        [Test]
        public void TestMatrix()
        {
            Vector3 testPoint = new Vector3(0, 1, 0);
            Matrix4x4 moveMatrix = new Matrix4x4(
                1, 0, 0, 0,
                0, 1, 0, 1,
                0, 0, 1, 0, 
                0, 0, 0, 1);
            moveMatrix.MultiplyPoint(testPoint);
            Console.WriteLine(testPoint);

        }

        [Test]
        public void TestCamera()
        {
            Camera camera = new Camera();
            Vector3 point = new Vector3(0, 0, -5);
            var projectionMatrix = camera.GetPerspectiveProjectionMatrix();
            point = projectionMatrix.MultiplyPoint(point);
            Console.WriteLine(point);
        }

        [Test]
        public void TestEuler()
        {
            Vector3 euler = new Vector3(0, 90, 0);
            var quaternion = Quaternion.Euler(euler);
            Console.WriteLine(quaternion);
            Console.WriteLine(quaternion.eulerAngles);
        }

        [Test]
        public void TestRotate()
        {
            Vector3 point = new Vector3(1, 0, 0);
            var mat = Matrix4x4.Rotate(Quaternion.Euler(0, 90, 0));
            point = mat.MultiplyPoint(point);
            Console.WriteLine(point);
        }
    }
}