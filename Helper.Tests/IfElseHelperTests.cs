using System;
using NUnit.Framework;

namespace Helper.Tests
{
    public class IfElseHelperTests
    {
        [TestCase(1, 2, -1)]
        [TestCase(2, 1, 3)]
        [TestCase(2, 2, 4)]
        [TestCase(-1, -2, -3)]
        [TestCase(0, 0, 0)]
        public void CalcCondition_WhenAAndBPassed_ShouldReturnCalculationResult(int a, int b, int expected)
        {
            int actual = IfElseHelper.CalcCondition(a, b);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 1)]
        [TestCase(1, -1, 2)]
        [TestCase(-1, 1, 4)]
        [TestCase(-1, -1, 3)]
        public void GetCoordinateQuater_WhenXYNotZero_ShouldQuater(int x, int y, int expected)
        {
            var actual = IfElseHelper.GetCoordinateQuater(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0)]
        [TestCase(0, -1)]
        [TestCase(0, 0)]
        public void GetCoordinateQuater_WhenXOrYIsZero_ShouldThrowArgumentException
            (int x, int y)
        {
            Assert.Throws<ArgumentException>(() => IfElseHelper.GetCoordinateQuater(x, y));
        }

        [TestCase(0, 1, 2, 0, 1, 2)]
        [TestCase(1, 2, 0, 0, 1, 2)]
        [TestCase(2, 1, 0, 0, 1, 2)]
        [TestCase(-2, -3, -1, -3, -2, -1)]
        [TestCase(1, -1, 0, -1, 0, 1)]
        public void SelectFromLowToHigh_WhenABCExist_ShoudABCInAscendingOrder(int a, int b, int c, int expectedA, int expectedB, int expectedC)
        {
            (int a, int b, int c) actual = IfElseHelper.SelectFromLowToHigh(a, b, c);
            (int a, int b, int c) expected = (expectedA, expectedB, expectedC);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 2, 2)]
        [TestCase(5, 3, 3)]
        public void GetRootOfQuadraticEquation_WhenDiscriminantLessThenZero_ShoudThrowArgumentException(float a, float b, float c)
        {
            Assert.Throws<ArgumentException>(() => IfElseHelper.GetRootOfQuadraticEquation(a, b, c));
        }

        [TestCase(0, 2, 2)]
        public void GetRootOfQuadraticEquation_WhenAIsEqualToZero_ShoudThrowDivideByZeroException(float a, float b, float c)
        {
            Assert.Throws<DivideByZeroException>(() => IfElseHelper.GetRootOfQuadraticEquation(a, b, c));
        }

        [TestCase(-2, 7, -6, 1.5, 2)]
        [TestCase(1, -10, 25, 5, 5)]
        public void GetRootOfQuadraticEquation_WhenDiscriminantMoreThenZero_ShoudThrowArgumentException(double a, double b, double c, double expectedA, double expectedB)
        {
            (double a, double b) actual = IfElseHelper.GetRootOfQuadraticEquation(a, b, c);
            (double a, double b) expected = (expectedA, expectedB);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, "ten")]
        [TestCase(11, "eleven")]
        [TestCase(12, "twelve")]
        [TestCase(13, "thirteen")]
        [TestCase(14, "fourteen")]
        [TestCase(15, "fifteen")]
        [TestCase(16, "sixteen")]
        [TestCase(17, "seventeen")]
        [TestCase(18, "eighteen")]
        [TestCase(19, "nineteen")]
        [TestCase(20, "twenty")]
        [TestCase(30, "thirty")]
        [TestCase(40, "fourty")]
        [TestCase(50, "fifty")]
        [TestCase(60, "sixty")]
        [TestCase(70, "seventy")]
        [TestCase(80, "eighty")]
        [TestCase(90, "ninety")]
        [TestCase(91, "ninety-one")]
        [TestCase(87, "eighty-seven")]
        [TestCase(72, "seventy-two")]
        [TestCase(68, "sixty-eight")]
        [TestCase(39, "thirty-nine")]
        public void GetCapitalizationOfNumber_WhenInputCorrect_ShouldReturnNumberCapitapization(int a, string expected)
        {
            string actual = IfElseHelper.GetCapitalizationOfNumber(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(100)]
        public void PrintNumberCapitalization_WhenInputMoreThenNintyNineAndLessOrEqualZero_ShouldThrowArgumentOutOfRangeException(int a)

        {
            Assert.Throws<ArgumentOutOfRangeException>(() => IfElseHelper.GetCapitalizationOfNumber(a));
        }
    }
}
