using PlanOfDaysLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanOfEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service.AddEvent("Party", "2002.03.23", "Monday");
            Service.AddEvent("Birthday", "2002.03.23", "Monday");
            Console.WriteLine(Service.AverageCountWithSpecifiedDayOfWeek("Monday"));
        }
    }
}
