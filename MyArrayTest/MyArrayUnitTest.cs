﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyArrayLibrary;
using System;

namespace MyArrayTest
{
    [TestClass]
    public class MyArrayUnitTest
    {
        [TestMethod]
        public void MetodForMyArray_Test1()
        {
            MyArray a = new MyArray(new double[] { 3.4, -2, -1.7});
            int expected = 2;

            Assert.AreEqual(expected, MyArray.MetodForMyArray(a));
        }

        [TestMethod]
        public void MetodForMyArray_Test2()
        {
            MyArray a = new MyArray(new double[] { 3.4, -2, -3.7, 7, -6.5 });
            int index = 3;
            int expected = 1;

            Assert.AreEqual(expected, MyArray.MetodForMyArray(a, index));
        }

        [TestMethod]
        public void MetodForMyArray_Test3()
        {
            MyArray a = new MyArray(new double[] { 3.4, -2, -3.7, 7, -6.5 });
            double value = 2;
            int expected = 2;

            Assert.AreEqual(expected, MyArray.MetodForMyArray(a, value));
        }

        [TestMethod]
        [DataRow(17, -6.5)]
        public void Multiplication_Test1(double expected1, double expected2)
        {
            MyArray a = new MyArray(new double[] { 3.4, -2, -3.7, 7, -6.5 });
            MyArray b = new MyArray(new double[] { 5, -2, 10, 1});

            Assert.AreEqual(expected1, (a * b)[0]);
            Assert.AreEqual(expected2, (a * b)[4]);
        }
    }
}
