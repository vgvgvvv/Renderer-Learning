using System;
using Common;
using MathLib;
using NUnit.Framework;

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
    }
}