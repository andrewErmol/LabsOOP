using System;

namespace FigureLibrary.Figures
{
    public class Rectangle : Figure
    {
        protected Point Point1;
        protected Point Point2;

        public Rectangle(Point firstPoint, Point secondPoint)
        {
            Point1 = firstPoint;
            Point2 = secondPoint;
        }

        public override bool CheckPoinBelonging(Point checkPoint)
        {
            bool isBelong = false;
            if (Point1.X < Point2.X && Point1.Y < Point2.Y)
            {
                if (Point1.X < checkPoint.X && Point2.X > checkPoint.X && Point1.Y < checkPoint.Y && Point2.Y > checkPoint.Y)
                {
                    isBelong = true;
                }
            }
            else if (Point1.X < Point2.X && Point1.Y > Point2.Y)
            {
                if (Point1.X < checkPoint.X && Point2.X > checkPoint.X && Point1.Y > checkPoint.Y && Point2.Y < checkPoint.Y)
                {
                    isBelong = true;
                }
            }
            else if (Point1.X > Point2.X && Point1.Y > Point2.Y)
            {
                if (Point1.X > checkPoint.X && Point2.X < checkPoint.X && Point1.Y > checkPoint.Y && Point2.Y < checkPoint.Y)
                {
                    isBelong = true;
                }
            }
            else if (Point1.X > Point2.X && Point1.Y < Point2.Y)
            {
                if (Point1.X > checkPoint.X && Point2.X < checkPoint.X && Point1.Y < checkPoint.Y && Point2.Y > checkPoint.Y)
                {
                    isBelong = true;
                }
            }

            return isBelong;
        }

        public override double GetPerimetr() => Math.Abs(Point2.X - Point1.X) * 2 + Math.Abs(Point2.Y - Point1.Y) * 2;

        public override double GetSquare() => Math.Abs((Point1.X - Point2.X) * (Point2.Y - Point1.Y));

        public override string ToString() => $"Type: rectangle\tFirst point: ({Point1.X}, {Point1.Y})\tSecond point: ({Point2.X}, {Point2.Y})\tPerimetr: {GetPerimetr()}\tSquare: {GetSquare()}";

        public string VertexOfRectangleAndSquare() => $"Vertice one: {Point1.X}, {Point1.X};\nVertice two: {Point1.X}, {Point2.Y};\nVertice three: {Point2.X}, {Point2.Y};\nVertice four: {Point2.X}, {Point1.Y}";

        public string SideOfRectangleAndSquare() => $"Width: {Math.Abs(Point2.X - Point1.X)}\nHeight: {Math.Abs(Point2.Y - Point1.Y)}";

        public string DiagonalOfRectangleAndSquare() => $"{Math.Sqrt(Math.Pow(Point2.X - Point1.X, 2) + Math.Pow(Point2.Y - Point1.Y, 2))}";
    }
}

