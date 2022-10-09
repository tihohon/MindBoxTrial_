using System;
using NUnit.Framework;
using Geometry;
using Geometry.Figures;

namespace GeometryTest
{
    [TestFixture]
    public class CalculateSquareTest
    {
        [TestCase(1, 3.141592653589793)]
        [TestCase(5, 78.53981633974483)]
        [TestCase(4.55534, 65.19157404875071)]
        [TestCase(23423423, 1723655999550504.2)]
        public void Circle_Square_Basic(double radius, double accurateSquare)
        {
            var circleSquare = CalculateArea.Square(radius);

            Assert.AreEqual(circleSquare, accurateSquare);
        }

        [TestCase(1, 5, 6, 0)]
        [TestCase(3.4444, 100, 99.4252, 169.29173226060442)]
        [TestCase(100, 100, 100, 4330.127018922193)]
        [TestCase(23423423.545254, 83423434.45, 63434324.13, 442556625037107.44)]
        public void Triangle_Square_Basic(double a, double b, double c, double accurateSquare)
        {
            var circleSquare = CalculateArea.Square(a, b, c);

            Assert.AreEqual(circleSquare, accurateSquare);
        }

        [Test]
        public void Figure_Square_Circle()
        {
            var figure = new Circle(5);

            var circleSquare = CalculateArea.Square(figure);

            Assert.AreEqual(circleSquare, 78.53981633974483);
        }

        [Test]
        public void Figure_Square_Triangle()
        {
            var figure = new Triangle(100, 100, 100);

            var circleSquare = CalculateArea.Square(figure);

            Assert.AreEqual(circleSquare, 4330.127018922193);
        }
    }
}