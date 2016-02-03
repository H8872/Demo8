using Microsoft.VisualStudio.TestTools.UnitTesting;
using T5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            //Arrange
            double[] array = {1, 2, 3};
            double expected = 6;

            //Act
            ArrayCalcs calc = new ArrayCalcs();
            double actual = calc.Sum(array);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            double[] array = {1, 2, 3 };
            double exp = 2;

            ArrayCalcs calc = new ArrayCalcs();
            double act = calc.Average(array);

            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void MinTest()
        {
            double[] array = { 1, 2, 3 };
            double exp = 1;

            ArrayCalcs calc = new ArrayCalcs();
            double act = calc.Min(array);


            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double[] array = { 1, 2, 3 };
            double exp = 3;

            ArrayCalcs calc = new ArrayCalcs();
            double act = calc.Max(array);

            Assert.AreEqual(exp, act);
        }
    }
}