using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayLibrary
{
    public class MyArray
    {
        public int Lenght { get; }
        private double[] ThisArray;
        public MyArray(double[] thisArray)
        {
            ThisArray = thisArray;
            Lenght = thisArray.Length;
        }

        public double this[int index]
        {
            get => ThisArray[index];
            set => ThisArray[index] = value;
        }

        public static int MetodsForMyArray(MyArray array)
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

        public static int MetodsForMyArray(MyArray array, int enteredNumber)
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

        public static int MetodsForMyArray(MyArray array, double value)
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
    }
}
