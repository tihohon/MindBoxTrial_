using System;
using NUnit.Framework;
using Geometry;
using Geometry.Figures;

namespace GeometryTest
{
    [TestFixture]
    public class TriangleTest
    {
        [TestCase(50, 100, 150, true)]
        [TestCase(50, 50, 75, false)]
        public void Triangle_IsRight_Basic(double a, double b, double c, bool isRight)
        {
            var triangle = new Triangle(a, b, c);

            var right = triangle.IsRight();
            
            Assert.AreEqual(right, right);
        }

        [TestCase(50, 100, 150, true)]
        [TestCase(50, 100, 25, false)]
        public void Triangle_Exist(double a, double b, double c, bool exist)
        {
            if (exist)
                Assert.DoesNotThrow(() => new Triangle(a, b, c));
            else
                Assert.Throws<ArgumentException>(() => new Triangle(a, b, c), "There is no such triangle!");
        }
    }
}