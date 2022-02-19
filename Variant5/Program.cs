using System;
using ExpressionLibrary;

namespace Variant5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string a = "12 + 3 * 2 - 5 * 7 + 20";
                Expression AD = new Expression(a);

                Console.WriteLine($"{AD.FindingResults()}");
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }
    }
}