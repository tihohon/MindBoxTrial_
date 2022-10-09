using Geometry.Figures;

namespace Geometry
{
    public static class CalculateArea
    {
        public static double Square(double a, double b, double c)
        {
            return new Triangle(a, b, c).Square();
        }

        public static double Square(double r)
        {
            return new Circle(r).Square();
        }

        public static double Square(IFigure figure)
        {
            return figure.Square();
        }
    }
}