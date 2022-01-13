using System;

namespace FigureLibrary.Figures
{
    public class Circle : Figure
    {
        Point center;
        public int Radius { get; }
        public delegate double Operation(int r);

        public Circle(Point center, int Radius)
        {
            this.center = center;
            this.Radius = Radius;
        }

        public override bool CheckPoinBelonging(Point checkPoint)
        {
            return (Math.Pow(checkPoint.X - center.X, 2) + Math.Pow(checkPoint.Y - center.Y, 2) < Math.Pow(Radius, 2));
        }

        public override double GetPerimetr()
        {
            return 2 * Math.PI * Radius;
        }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Type: circle\tCenter: ({center.X}, {center.Y})\tRadius: {Radius}\tPerimetr: {GetPerimetr()}\tSquare: {GetSquare()}";
        }

        public Operation Diametr = (radius) => radius* 2;
    }
}
