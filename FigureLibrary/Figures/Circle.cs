using System;

namespace FigureLibrary.Figures
{
    public class Circle : Figure
    {
        Point center;
        int radius;

        public Circle(int number, Point center, int radius) : base(number)
        {
            this.center = center;
            this.radius = radius;
        }

        public override bool CheckPoinBelonging(Point checkPoint)
        {
            if (Math.Pow(checkPoint.X - center.X, 2) + Math.Pow(checkPoint.Y - center.Y, 2) < Math.Pow(radius, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double GetPerimetr()
        {
            return 2 * Math.PI * radius;
        }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return $"Type: circle\tNumber: {Number}\tCenter: ({center.X}, {center.Y})\tRadius: {radius}\tPerimetr: {GetPerimetr()}\tSquare: {GetSquare()}";
        }
        public double Diametr()
        {
            return radius * 2;
        }
    }
}
