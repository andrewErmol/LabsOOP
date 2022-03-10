using System;
using System.Collections.Generic;

namespace MyArrayLibrary
{   /// <summary>
    /// Class describe one-dimensional array
    /// </summary>
    public class MyArray
    {
        public int Lenght { get; }
        private List<double> ThisArray;

        /// <summary>
        /// Created objects MyArray class
        /// </summary>
        /// <param name="thisArray">Object of MyArray class</param>
        public MyArray(List<double> thisArray)
        {
            ThisArray = thisArray;
            Lenght = thisArray.Count;
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
        public int CountNegativeValues()
        {
            int count = 0;
            for (int i = 0; i < Lenght; i++)
            {
                if (this[i] < 0)
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
        public int CountElemetsAfterEnteredValue(int enteredNumber)
        {
            int count = 0;
            for (int i = 0; i < Lenght; i++) 
            {
                if (i > enteredNumber)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Serch count elemets after entered number
        /// </summary>
        /// <param name="array"></param>
        /// <param name="enteredNumber"></param>
        /// <returns></returns>
        public int CountElemetsAfterEnteredValue(string enteredNumber)
        {
            if (!int.TryParse(enteredNumber, out int number))
            {
                throw new Exception("Entered value is used be integer");
            }

            int count = 0;
            for (int i = 0; i < Lenght; i++)
            {
                if (i > number)
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
        public int CountElementsGreaterEnteredValue(double value)
        {
            int count = 0;
            for (int i = 0; i < Lenght; i++)
            {
                if (this[i] > value)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Operator for creating new object MyArray as a result of multiplication two arrays
        /// </summary>
        /// <param name="array1">Array needy of multiplication (MyArray object)</param>
        /// <param name="array2">Array needy of multiplication (IEnumerable collection)</param>
        /// <returns></returns>
        public static MyArray operator *(MyArray array1, IEnumerable<double> array2)
        {
            List<double> myArray2 = new List<double>();
            myArray2.AddRange(array2);
            return Multiply(array1, new MyArray(myArray2));
        }

        /// <summary>
        /// Operator for creating new object MyArray as a result of multiplication two arrays
        /// </summary>
        /// <param name="array1">Array needy of multiplication (MyArray object)</param>
        /// <param name="array2">Array needy of multiplication (MyArray object)</param>
        /// <returns>Object MyArray class</returns>
        public static MyArray operator *(MyArray array1, MyArray array2)
        {
            return Multiply(array1, array2);
        }

        /// <summary>
        /// Operator for creating new object MyArray as a result of multiplication two arrays
        /// </summary>
        /// <param name="array1">Array needy of multiplication (MyArray object)</param>
        /// <param name="array2">Array needy of multiplication (double[] object)</param>
        /// <returns></returns>
        public static MyArray operator *(MyArray array1, double[] array2)
        {
            List<double> myArray2 = new List<double>(array2.Length);
            myArray2.AddRange(array2);
            return Multiply(array1, new MyArray(myArray2));
        }

        /// <summary>
        /// Method for arrays multiplication 
        /// </summary>
        /// <param name="array1">Array needy of multiplication (MyArray object)</param>
        /// <param name="array2">Array needy of multiplication (MyArray object)</param>
        /// <returns>Result of multiplication</returns>
        private static MyArray Multiply(MyArray array1, MyArray array2)
        {
            List<double> arr;
            if (array1.Lenght > array2.Lenght)
            {
                arr = new List<double>(array1.Lenght);
                for (int i = 0; i < array1.Lenght; i++)
                {
                    if (i < array2.Lenght)
                    {
                        arr.Add(array1[i] * array2[i]);
                    }
                    else
                    {
                        arr.Add(array1[i]);
                    }
                }
            }
            else if (array1.Lenght < array2.Lenght)
            {
                arr = new List<double>(array2.Lenght);
                for (int i = 0; i < array2.Lenght; i++)
                {
                    if (i < array1.Lenght)
                    {
                        arr.Add(array1[i] * array2[i]);
                    }
                    else
                    {
                        arr.Add(array2[i]);
                    }
                }
            }
            else
            {
                arr = new List<double>(array1.Lenght);
                for (int i = 0; i < array1.Lenght; i++)
                {
                    arr.Add(array1[i] * array2[i]);
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
            List<double> array = new List<double>(enteredValue);
            for (int i = 0; i < enteredValue; i++)
            {
                array.Add(1);
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
