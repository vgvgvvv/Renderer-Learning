using System;
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
    }
}