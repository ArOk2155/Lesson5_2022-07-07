using NUnit.Framework;

namespace Helper.Tests
{
    public class Tests
    {
        [TestCase(3, 180)]
        [TestCase(2, 120)]
        [TestCase(4, 240)]
        [TestCase(5, 300)]

        public void Minutes_When_ShouldMinutes(int a, int expected)
        {
            //Arrange

            //Act
            int actual = Helper.LinearEquations.CalculateMinutes(a);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}