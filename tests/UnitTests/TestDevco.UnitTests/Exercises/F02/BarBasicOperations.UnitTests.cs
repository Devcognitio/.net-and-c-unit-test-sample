using TestDevco.Exercises.F02;

namespace TestDevco.UnitTests.Exercises.F02
{
    [TestFixture]
    public class BarBasicOperationsTests
    {
        [Test]
        public void Sum_WhenCalledWithValidNumbers_ShouldReturnSum()
        {
            // Arrange
            const int firstNumber = 3;
            const int secondNumber = 4;
            const int expectedSum = 7;

            // Act
            int result = BarBasicOperations.Sum(firstNumber, secondNumber);

            // Assert
            Assert.That(result, Is.EqualTo(expectedSum));
        }

        [TestCase(1, 3)]
        [TestCase(-3, 1)]
        [TestCase(3, 9)]
        public void MinValue_WhenFirstValueIsLessThanSecondValue_ShouldReturnFirstValue(int firstValue, int secondValue)
        {
            // Act
            int result = BarBasicOperations.MinValue(firstValue, secondValue);

            // Assert
            Assert.That(result, Is.EqualTo(firstValue));
        }

        [TestCase(5, 3, ExpectedResult = 3)]
        [TestCase(1, -1, ExpectedResult = -1)]
        [TestCase(7, 5, ExpectedResult = 5)]
        public int MinValue_WhenFirstValueIsGreaterThanSecondValue_ShouldReturnSecondValue(int numberOne, int numberTwo)
        {
            return BarBasicOperations.MinValue(numberOne, numberTwo);
        }
    }
}