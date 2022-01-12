using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures
{
    public class Rectangle : Figure
    {
        protected Point point1;
        protected Point point2;

        public Rectangle(int number, Point firstPoint, Point secondPoint) : base(number)
        {
            point1 = firstPoint;
            point2 = secondPoint;
        }

        public override bool CheckPoinBelonging(Point checkPoint)
        {
            bool isBelong = false;
            if (point1.X < point2.X && point1.Y < point2.Y)
            {
                if (point1.X < checkPoint.X && point2.X > checkPoint.X && point1.Y < checkPoint.Y && point2.Y > checkPoint.Y)
                {
                    isBelong = true;
                }
            }
            else if (point1.X < point2.X && point1.Y > point2.Y)
            {
                if (point1.X < checkPoint.X && point2.X > checkPoint.X && point1.Y > checkPoint.Y && point2.Y < checkPoint.Y)
                {
                    isBelong = true;
                }
            }
            else if (point1.X > point2.X && point1.Y > point2.Y)
            {
                if (point1.X > checkPoint.X && point2.X < checkPoint.X && point1.Y > checkPoint.Y && point2.Y < checkPoint.Y)
                {
                    isBelong = true;
                }
            }
            else if (point1.X > point2.X && point1.Y < point2.Y)
            {
                if (point1.X > checkPoint.X && point2.X < checkPoint.X && point1.Y < checkPoint.Y && point2.Y > checkPoint.Y)
                {
                    isBelong = true;
                }
            }

            return isBelong;
        }

        public override double GetPerimetr()
        {
            return Math.Abs(point2.X - point1.X) * 2 + Math.Abs(point2.Y - point1.Y) * 2;
        }

        public override double GetSquare()
        {
            return Math.Abs((point1.X - point2.X) * (point2.Y - point1.Y));
        }

        public override string ToString()
        {
            return $"Type: rectangle\t\tNumber: {Number}\tFirst point: ({point1.X}, {point1.Y})\tSecond point: ({point2.X}, {point2.Y})\tPerimetr: {GetPerimetr()}\tSquare: {GetSquare()}";
        }

        public string VertexOfRectangleAndSquare()
        {
            return $"Vertice one: {point1.X}, {point1.X};\nVertice two: {point1.X}, {point2.Y};\nVertice three: {point2.X}, {point2.Y};\nVertice four: {point2.X}, {point1.Y}";
        }

        public string SideOfRectangleAndSquare()
        {
            return $"Width: {Math.Abs(point2.X - point1.X)}\nHeight: {Math.Abs(point2.Y - point1.Y)}";
        }

        public string DiagonalOfRectangleAndSquare()
        {
            return $"{Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2))}";
        }
    }
}

