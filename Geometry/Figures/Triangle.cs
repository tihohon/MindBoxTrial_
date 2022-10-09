using System;
using System.Collections.Generic;
using System.Linq;

namespace Geometry.Figures
{
    public class Triangle : IFigure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        private readonly double _perimeter;


        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            _perimeter = a + b + c;
            var sids = new List<double> {_a, _b, _c};
            if (sids.Max() * 2 > sids.Sum())
                throw new ArgumentException("There is no such triangle!");
        }

        public double Square()
        {
            var p = _perimeter / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRight()
        {
            var sids = new List<double> {_a, _b, _c};
            return Math.Abs(sids.Max() * 2 - sids.Sum()) < Math.Pow(10, -18);
        }
    }
}