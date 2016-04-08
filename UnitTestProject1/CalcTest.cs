using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication4;
namespace UnitTestProject1
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestAddFunctionality()
        {
            Calculatron Calc = new Calculatron();
            Assert.AreEqual(Calc.Add(1, 3),(1 + 3));
        }

        [TestMethod]
        public void TestSubtractFunctionality()
        {
            Calculatron Calc = new Calculatron();
            Assert.AreEqual(Calc.Subtract(1, 3), (1 - 3));
        }

        [TestMethod]
        public void TestMultiplyFunctionality()
        {
            Calculatron Calc = new Calculatron();
            Assert.AreEqual(Calc.Multiply(1, 3), (1 * 3));
        }

        [TestMethod]
        public void TestDivisionFunctionality()
        {
            Calculatron Calc = new Calculatron();
            Assert.AreEqual(Calc.Divide(6, 3), (6 / 3));
        }
    }
}
