using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorThingything;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorThingything.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            Calculator calc = new Calculator();
            int number1 = 5;
            int number2 = 7;
            int expected = 12;

            //Act
            int actual = calc.Add(number1, number2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calc = new Calculator();
            int number1 = 5;
            int number2 = 7;
            int expected = 35;

            int actual = calc.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }
    }
}