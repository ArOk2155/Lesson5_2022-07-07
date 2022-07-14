using NUnit.Framework;
using System;

namespace Helper.Tests
{
    public class Tests
    {
        [TestCase(1, 60)]
        [TestCase(9, 540)]
        public void CalculateMinutes_WhenHousrLessThanZero_ShouldThrowArithmeticException(int hours, int expected)
        {
            int actual = LinearEquations.CalculateMinutes(hours);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-2)]
        public void CalculateMinutes_WhenHousrLessThanZero_ShouldThrowArithmeticException
            (int hours)
        {
            Assert.Throws<ArithmeticException>(() =>
            {
                LinearEquations.CalculateMinutes(hours);
            });
        }


        [TestCase(-1, -1)]
        public void CalculateSolution_WhenAAndBAreEqual_ShouldThrowDivideByZeroException(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                LinearEquations.CalculateSolution(a, b);
            });
        }

        [TestCase(1, 2, 9)]
        [TestCase(-2, 4, 1)]
        [TestCase(-1, -2, 1)]
        public void CalculateSolution_WhenAAndBAreEqual_ShouldThrowCalculateSolution(int a, int b, double expected)
        {
            double actual = LinearEquations.CalculateSolution(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
    
}