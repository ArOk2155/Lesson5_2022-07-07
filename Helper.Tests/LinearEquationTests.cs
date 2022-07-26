using NUnit.Framework;
using System;

namespace Helper.Tests
{
    public class Tests
    {
        [TestCase(1, 60)]
        [TestCase(9, 540)]
        public void CalculateMinutes_WhenHousrMoreThanZero_ShouldThrowArithmeticException(int hours, int expected)
        {
            int actual = LinearEquations.CalculateMinutes(hours);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-2)]
        public void CalculateMinutes_WhenHousrZeroOrLessThanZero_ShouldThrowArithmeticException
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
        public void CalculateSolution_WhenAAndBNotEqual_ShouldThrowCalculateSolution(int a, int b, double expected)
        {
            double actual = LinearEquations.CalculateSolution(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 5, 5, 1)]
        [TestCase(1, 10, 10, 1)]
        [TestCase(-1, -1, -1, -1)]
        public void Swap_WhenHasValues_ShouldSwap(int a, int b, int expA, int expB)
        {
            (int a, int b) actual = LinearEquations.Swap(ref a, ref b);

            Assert.AreEqual((expA, expB), (actual.a, actual.b));
        }
        
        [TestCase(1, 0)]
        public void CalculateDivisionAndRemainderFromDivision_WhenBAreZero_ShouldThrowDivideByZeroException(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                LinearEquations.CalculateDivisionAndRemainderFromDivision(a, b);
            });
        }

        [TestCase(15, 5, 3, 0)]
        [TestCase(4, 3, 1, 1)]
        [TestCase(-4, 3, -1, -1)]
        public void CalculateDivisionAndRemainderFromDivision_WhenNumAreNotZero_ShouldResult(int a, int b, int expA, int expB)
        {
            (int a, int b) actual = LinearEquations.CalculateDivisionAndRemainderFromDivision(a, b);

            Assert.AreEqual((expA, expB), (actual.a, actual.b));
        }

        [TestCase(0, 5, 3)]
        public void CalcLinearEquation_WhenAIsZero_ShouldThrowDivideByZeroException(int a, int b, int c)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                LinearEquations.CalcLinearEquation(a, b, c);
            });
        }
        
        [TestCase(-1, 1, 2, -1)]
        [TestCase(1, -1, 0, 1)]
        [TestCase(-2, 0, 1, (float)-0.5)]
        public void CalcLinearEquation_WhenAIsZero_ShouldResult(int a, int b, int c, float expected)
        {
            float actual = LinearEquations.CalcLinearEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

    }
    
}