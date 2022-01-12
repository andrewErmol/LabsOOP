using System;

namespace FigureLibrary.Figures
{
    public class Square : Rectangle
    {
        public Square(int number, Point firstPoint, Point secondPoint) : base(number, firstPoint, secondPoint)
        {
            CheckExistance(firstPoint, secondPoint);
        }

        private void CheckExistance(Point point1, Point point2)
        {
            if (!(point1.X - point2.X == point1.Y - point2.Y))
            {
                throw new Exception("Incorrect values were input");
            }
        }

        public override string ToString()
        {
            return $"Type: square\tNumber: {Number}\tFirst point: ({point1.X}, {point1.Y})\tSecond point: ({point2.X}, {point2.Y})\tPerimetr: {GetPerimetr()}\tSquare: {GetSquare()}";
        }
    }
}

