using System;
using System.Collections.Generic;

namespace FigureLibrary
{
    public abstract class Figure
    {
        public abstract double GetPerimetr();
        public abstract double GetSquare();
        public abstract bool CheckPoinBelonging(Point checkPoint);
    }
}
