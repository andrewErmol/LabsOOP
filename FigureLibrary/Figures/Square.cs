using System;

namespace FigureLibrary.Figures
{
    public class Square : Rectangle
    {
        public Square(Point firstPoint, Point secondPoint) : base(firstPoint, secondPoint)
        {
            CheckExistance(firstPoint, secondPoint);
        }

        private void CheckExistance(Point Point1, Point Point2)
        {
            if (!(Point1.X - Point2.X == Point1.Y - Point2.Y))
            {
                throw new Exception("Entered points do not form square");
            }
        }

        public override string ToString() => $"Type: square\tFirst point: ({Point1.X}, {Point1.Y})\tSecond point: ({Point2.X}, {Point2.Y})\tPerimetr: {GetPerimetr()}\tSquare: {GetSquare()}";
    }
}

