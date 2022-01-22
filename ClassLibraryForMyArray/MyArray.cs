using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayLibrary
{   /// <summary>
    /// Class describe one-dimensional array
    /// </summary>
    public class MyArray
    {
        public int Lenght { get; }
        private double[] ThisArray;

        /// <summary>
        /// Created objects MyArray class
        /// </summary>
        /// <param name="thisArray">Object of MyArray class</param>
        public MyArray(double[] thisArray)
        {
            ThisArray = thisArray;
            Lenght = thisArray.Length;
        }

        /// <summary>
        /// Allows you to get an element by number
        /// </summary>
        /// <param name="index">integer value describe number of the array elements</param>
        /// <returns></returns>
        public double this[int index]
        {
            get => ThisArray[index];
            set => ThisArray[index] = value;
        }

        /// <summary>
        /// search count negative values
        /// </summary>
        /// <param name="array">one-dimensional array</param>
        /// <returns>count negative values</returns>
        public static int MetodForMyArray(MyArray array)
        {
            int count = 0;
            for (int i = 0; i < array.Lenght; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Serch count elemets after entered number
        /// </summary>
        /// <param name="array">one-dimensional array</param>
        /// <param name="enteredNumber"></param>
        /// <returns>count elemets after entered number</returns>
        public static int MetodForMyArray(MyArray array, int enteredNumber)
        {
            int count = 0;
            for (int i = 0; i < array.Lenght; i++)
            {
                if (i > enteredNumber)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Serch count elements which are greater then the entered value
        /// </summary>
        /// <param name="array">one-dimensional array</param>
        /// <param name="value"> entered value</param>
        /// <returns>Count elements which are greater then the entered value</returns>
        public static int MetodForMyArray(MyArray array, double value)
        {
            int count = 0;
            for (int i = 0; i < array.Lenght; i++)
            {
                if (array[i] > value)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Creat new object MyArray as a result of multiplication two arrays
        /// </summary>
        /// <param name="array1">Array needy of multiplication</param>
        /// <param name="array2">Array needy of multiplication</param>
        /// <returns>Object MyArray class</returns>
        public static MyArray operator *(MyArray array1, MyArray array2)
        {
            double[] arr;
            if (array1.Lenght > array2.Lenght)
            {
                arr = new double[array1.Lenght];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < array2.Lenght)
                    {
                        arr[i] = array1[i] * array2[i];
                    }
                    else
                    {
                        arr[i] = array1[i];
                    }
                }
            }
            else if (array1.Lenght < array2.Lenght)
            {
                arr = new double[array2.Lenght];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < array1.Lenght)
                    {
                        arr[i] = array1[i] * array2[i];
                    }
                    else
                    {
                        arr[i] = array2[i];
                    }
                }
            }
            else
            {
                arr = new double[array1.Lenght];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = array1[i] * array2[i];
                }
            }

            return new MyArray(arr);
        }

        /// <summary>
        /// Conversion type integer in type MyArray
        /// </summary>
        /// <param name="enteredValue">integer value</param>
        public static explicit operator MyArray(int enteredValue)
        {
            double[] array = new double[enteredValue];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1;
            }

            return new MyArray(array);
        }

        /// <summary>
        /// Method to get string value of MyArray object
        /// </summary>
        /// <returns>string MyArray</returns>
        public override string ToString()
        {
            string res = "";

            for (int i = 0; i < Lenght; i++)
            {
                if (i != Lenght - 1)
                {
                    res += $"{ThisArray[i]} ";
                }
                else
                {
                    res += $"{ThisArray[i]}";
                }
            }

            return res;
        }
    }
}
