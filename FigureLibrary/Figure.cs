using System;
using System.Collections.Generic;

namespace FigureLibrary
{
    public abstract class Figure
    {
        public int Number { get; }
        static List<int> numberList = new List<int>();

        public Figure(int number)
        {
            if (numberList.Contains(number))
            {
                throw new Exception("Such number is already exist");
            }
            numberList.Add(number);
            Number = number;
        }

        public abstract double GetPerimetr();
        public abstract double GetSquare();
        public abstract bool CheckPoinBelonging(Point checkPoint);
    }
}
