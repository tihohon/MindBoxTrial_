using System;

namespace Geometry.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Square()
        {
            return Math.PI * _radius * _radius;
        }
    }
}