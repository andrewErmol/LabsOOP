using System;

namespace FigureLibrary.Figures
{
    public class Circle : Figure
    {
        Point center;
        int radius;

        public Circle(Point center, int radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public override bool CheckPoinBelonging(Point checkPoint) => (Math.Pow(checkPoint.X - center.X, 2) + Math.Pow(checkPoint.Y - center.Y, 2) < Math.Pow(radius, 2));

        public override double GetPerimetr() => 2 * Math.PI * radius;

        public override double GetSquare() => Math.PI * Math.Pow(radius, 2);

        public override string ToString() => $"Type: circle\tCenter: ({center.X}, {center.Y})\tRadius: {radius}\tPerimetr: {GetPerimetr()}\tSquare: {GetSquare()}";

        public double Diametr() => radius * 2;
    }
}
