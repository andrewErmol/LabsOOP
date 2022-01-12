using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyArrayLibrary
{
    public class MyArray
    {
        private double[] thisArray;
        public int Lenght { get; private set; }

        public MyArray(double[] thisArray)
        {
            this.thisArray = thisArray;
            Lenght = thisArray.Length;
        }

        public double this[int index]
        {
            get
            {
                return thisArray[index];
            }
        }

        public void ChangeArray(double[] newArr)
        {
            this.thisArray = newArr;
            Lenght = thisArray.Length;
        }

        public static MyArray operator +(MyArray array1, MyArray array2)
        {
            double[] arr = new double[array1.Lenght + array2.Lenght];

            for (int i = 0; i < array1.Lenght; i++)
            {
                arr[i] = array1[i];
            }

            for (int i = array1.Lenght; i < array1.Lenght + array2.Lenght; i++)
            {
                arr[i] = array2[i - array1.Lenght];
            }
            return new MyArray(arr);
        }

        public static MyArray operator *(MyArray array, int x)
        {
            double[] arr = new double[array.Lenght];

            for (int i = 0; i < array.Lenght; i++)
            {
                arr[i] = array[i] * x;
            }

            return new MyArray(arr);
        }

        public static MyArray operator /(MyArray array, int x)
        {
            double[] arr = new double[array.Lenght];

            for (int i = 0; i < array.Lenght; i++)
            {
                arr[i] = array[i] / x;
            }

            return new MyArray(arr);
        }

        public override string ToString()
        {
            string res = "";

            for (int i = 0; i < Lenght; i++)
            {
                if (i != Lenght - 1)
                {
                    res += $"{thisArray[i]} ";
                }
                else
                {
                    res += $"{thisArray[i]}";
                }
            }

            return res;
        }
    }
}
