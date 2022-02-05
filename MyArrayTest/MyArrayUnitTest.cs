using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyArrayLibrary;
using System.Collections.Generic;

namespace MyArrayTest
{
    [TestClass]
    public class MyArrayUnitTest
    {
        [TestMethod]
        public void CountNegativeValues_Test()
        {
            MyArray a = new MyArray(new List<double>() { 3.4, -2, -1.7});
            int expected = 2;

            Assert.AreEqual(expected, a.CountNegativeValues());
        }

        [TestMethod]
        public void CountElemetsAfterEnteredValue_Test1()
        {
            MyArray a = new MyArray(new List<double>() { 3.4, -2, -3.7, 7, -6.5 });
            int index = 3;
            int expected = 1;
            Assert.AreEqual(expected, a.CountElemetsAfterEnteredValue(index));
        }

        public void CountElemetsAfterEnteredValue_Test2()
        {
            MyArray a = new MyArray(new List<double>() { 3.4, -2, -3.7, 7, -6.5 });
            string index = "3";
            int expected = 1;
            Assert.AreEqual(expected, a.CountElemetsAfterEnteredValue(index));
        }

        [TestMethod]
        public void CountElementsGreaterEnteredValue_Test()
        {
            MyArray a = new MyArray(new List<double>() { 3.4, -2, -3.7, 7, -6.5 });
            double value = 2;
            int expected = 2;

            Assert.AreEqual(expected, a.CountElementsGreaterEnteredValue(value));
        }

        [TestMethod]
        [DataRow(17, -6.5)]
        public void Multiplication_Test1_1(double expected1, double expected2)
        {
            MyArray a = new MyArray(new List<double>() { 3.4, -2, -3.7, 7, -6.5 });
            MyArray b = new MyArray(new List<double>() { 5, -2, 10, 1});

            Assert.AreEqual(expected1, (a * b)[0]);
            Assert.AreEqual(expected2, (a * b)[4]);
        }

        [TestMethod]
        [DataRow(18, 36)]
        public void Multiplication_Test1_2(double expected1, double expected2)
        {
            MyArray a = new MyArray(new List<double>() { 3.6, 5, 2.4, 4, 6, 5 });
            MyArray b = new MyArray(new List<double>() { 5, 23, 45, 21, 4.1, 7.2 });

            Assert.AreEqual(expected1, (a * b)[0]);
            Assert.AreEqual(expected2, (a * b)[5]);
        }

        [TestMethod]
        [DataRow(18, 40)]
        public void Multiplication_Test2(double expected1, double expected2)
        {
            MyArray a = new MyArray(new List<double>() { 3.6, 5, 2.4, 4, 6, 5 });
            double[] b = new double[6] { 5, 23, 45, 21, 4.1, 8 };

            Assert.AreEqual(expected1, (a * b)[0]);
            Assert.AreEqual(expected2, (a * b)[5]);
        }

        [TestMethod]
        [DataRow(3.6, 5)]
        public void Multiplication_Test3(double expected1, double expected2)
        {
            MyArray a = new MyArray(new List<double>() { 3.6, 5, 2.4, 4, 6, 5 });
            double[] Bcheck = new double[5] { 1, 2, -4, 5, 3 };

            Assert.AreEqual(expected1, (a * (IEnumerable<double>)Bcheck)[0]);
            Assert.AreEqual(expected2, (a * (IEnumerable<double>)Bcheck)[5]);
        }

        [TestMethod]
        [DataRow(1, 1, 7)]
        public void TypeConversion_Test(double expected1, double expected2, int enteredValue)
        {
            MyArray array = (MyArray)enteredValue;

            Assert.AreEqual(expected1, array[0]);
            Assert.AreEqual(expected2, array[6]);
            Assert.AreEqual(enteredValue, array.Lenght);
        }
    }
}
