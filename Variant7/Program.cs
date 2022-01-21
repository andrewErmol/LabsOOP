using MyArrayLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using System.Threading.Tasks;

namespace Variant7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Array A:");
                MyArray A = new MyArray(CreateMyArray());
                
                Console.WriteLine("Array B:");
                MyArray B = new MyArray(CreateMyArray());
                
                Console.WriteLine("Array C:");
                MyArray C = new MyArray(CreateMyArray());
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }
        static double[] CreateMyArray()
        {
            Console.Write("Enter count elements of array: ");
            if (!int.TryParse(Console.ReadLine(), out int count))
            {
                throw new Exception("Entered value is used be integer");
            }

            double[] Array = new double[count];

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"Enter {i + 1} element of array:");
                if (!double.TryParse(Console.ReadLine(), out double value))
                {
                    throw new Exception("Entered value is used be double");
                }
                Array[i] = value;
            }

            return Array;
        }
    }
}
