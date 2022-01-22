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
                
                Console.WriteLine("\nArray B:");
                MyArray B = new MyArray(CreateMyArray());
                
                Console.WriteLine("\nArray C:");
                MyArray C = new MyArray(CreateMyArray());

                Console.WriteLine($"\nCount negative elements of array A * array B: " +
                    $"{MyArray.MetodForMyArray(A * B)}");

                Console.WriteLine($"\nCount element after elements number = 3 of array A: " +
                    $"{MyArray.MetodForMyArray(A, 3)}");

                Console.WriteLine($"\nCount element after elements number = 2 of array C: " +
                    $"{MyArray.MetodForMyArray(C, 2)}");

                bool isConditionMet = false;
                for (int i = 0; i < (A * B).Lenght; i++)
                {
                    if ((A * B)[i] > -5.3 && (A * B)[i] < 0)
                    {
                        isConditionMet = true;
                    }
                }
                if (isConditionMet)
                {
                    MyArray array = (MyArray)500;
                    for (int i = 0; i < array.Lenght; i++)
                    {
                        if (i % 10 == 0)
                        {
                            array[i] = 0;
                        }
                    }
                    Console.WriteLine(array.ToString());
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }

        /// <summary>
        /// Created and write values of MyArray
        /// </summary>
        /// <returns>Object MyArray</returns>
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
