using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCalc;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestPlus()
        {
            double a=2.3; double b=1.2;
            double excepted = a + b;
            double actual = MyCalc.MyCalc.Sum(2.3, 1.2);
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestMinus()
        {
            double a = 5.5; double b = 6.3;
            double excepted = a - b;
            double actual = MyCalc.MyCalc.Minus(5.5, 6.2);
            Assert.AreEqual(excepted, actual);
            Assert.AreEqual(excepted, actual, 0.1);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivision()
        {
            double a = 4; double b = 2;
            double excepted = a / b;
            double actual = MyCalc.MyCalc.Division(4, 0);
            Assert.AreEqual(excepted, actual);
        }


    }
}