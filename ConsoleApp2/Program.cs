using MyArrayLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("Enter count of array one: ");
            int count1 = Convert.ToInt32(Console.ReadLine());
            double[] array1 = new double[count1];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(-10, 10);
            }
            MyArray myArray1 = new MyArray(array1);
            Console.WriteLine(myArray1.ToString() + "\n");

            Console.Write("Enter count of array two: ");
            int count2 = Convert.ToInt32(Console.ReadLine());
            double[] array2 = new double[count2];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(-10, 10);
            }
            MyArray myArray2 = new MyArray(array2);
            Console.WriteLine(myArray2.ToString() + "\n");


            int menuItem = -1;

            while (menuItem != 0)
            {
                Console.WriteLine("1. Sum of arrays");
                Console.WriteLine("2. Multiply array with specified value");
                Console.WriteLine("3. Division array with specified value");
                Console.WriteLine("4. Change array of arrays");
                Console.WriteLine("0. Exit");

                menuItem = Convert.ToInt32(Console.ReadLine());

                try
                {
                    switch (menuItem)
                    {
                        case 1:
                            Console.WriteLine($"{(myArray1 + myArray2).ToString()}");
                            break;
                        case 2:
                            Console.WriteLine(Multiply(myArray1, myArray2));
                            break;
                        case 3:
                            Console.WriteLine(Division(myArray1, myArray2));
                            break;
                        case 4:
                            Change(myArray1, myArray2, count1, count2);
                            break;
                        case 0:
                            Console.WriteLine("End of program");
                            break;
                        default:
                            Console.WriteLine("This menu item does not exist");
                            break;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("Error: " + error.Message);
                }
            }
        }

        static void Change(MyArray myArray1, MyArray myArray2, int count1, int count2)
        {
            Random random = new Random();

            int menuitem = -1;

            Console.WriteLine($"1. Change first array\n" +
                $"2. Change second array\n" +
                $"3. Change both array");

            menuitem = Convert.ToInt32(Console.ReadLine());

            switch (menuitem)
            {
                case 1:
                    double[] array1 = new double[count1];
                    for (int i = 0; i < array1.Length; i++)
                    {
                        array1[i] = random.Next(-10, 10);
                    }
                    myArray1.ChangeArray(array1);
                    Console.WriteLine(myArray1.ToString() + "\n");
                    break;
                case 2:
                    double[] array2 = new double[count2];
                    for (int i = 0; i < array2.Length; i++)
                    {
                        array2[i] = random.Next(-10, 10);
                    }

                    myArray2.ChangeArray(array2);
                    Console.WriteLine(myArray2.ToString() + "\n");
                    break;
                case 3:
                    double[] array12 = new double[count1];
                    for (int i = 0; i < array12.Length; i++)
                    {
                        array12[i] = random.Next(-10, 10);
                    }
                    myArray1.ChangeArray(array12);
                    Console.WriteLine(myArray1.ToString() + "\n");

                    double[] array22 = new double[count2];
                    for (int i = 0; i < array22.Length; i++)
                    {
                        array22[i] = random.Next(-10, 10);
                    }
                    myArray2.ChangeArray(array22);
                    Console.WriteLine(myArray2.ToString() + "\n");
                    break;
                default:
                    throw new Exception("specified numbers of menu does not exist");
            }
        }

        static string Multiply(MyArray myArray1, MyArray myArray2)
        {
            string res = string.Empty;

            Console.Write("Enter numbeer of array: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value for operation: ");
            int value = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                res = $"{(myArray1 * value).ToString()}";
            }
            else if (number == 2)
            {
                res = $"{(myArray2 * value).ToString()}";
            }
            else
            {
                throw new Exception("Array with specified number does not exist");
            }
            return res;
        }

        static string Division(MyArray myArray1, MyArray myArray2)
        {
            string res = string.Empty;

            Console.Write("Enter numbeer of array: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value for operation: ");
            int value = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                res = $"{(myArray1 / value).ToString()}";
            }
            else if (number == 2)
            {
                res = $"{(myArray2 / value).ToString()}";
            }
            else
            {
                throw new Exception("Array with specified number does not exist");
            }
            return res;
        }
    }
}
