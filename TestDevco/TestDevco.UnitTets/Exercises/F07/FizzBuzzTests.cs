using TestDevco.Exercises.F07;

namespace TestDevco.UnitTets.Exercises.F07
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void GetFizzBuzz_InputIsDivisibleBy3And5_ReturnFizzBuzz(int number)
        {
            //Arrange y Act
            var result = FizzBuzz.GetFizzBuzz(number);
            //Assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }


        [Test]
        public void GetFizzBuzz_InputIsDivisibleBy3Only_ReturnFizz()
        {
            //Arrange y Act
            var result = FizzBuzz.GetFizzBuzz(3);
            //Assert
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetFizzBuzz_InputIsDivisibleBy5Only_ReturnBuzz()
        {
            //Arrange y Act
            var result = FizzBuzz.GetFizzBuzz(5);
            //Assert
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetFizzBuzz_InputIsNotDivisibleBy3And5_ReturnNumber()
        {
            //Arrange y Act
            var result = FizzBuzz.GetFizzBuzz(1);
            //Assert
            Assert.That(result, Is.EqualTo("1"));
        }


        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(1, "1")]
        public void GetFizzBuzz_WhenCalled_ReturnFizzBuzzString(int number, string resultFb)
        {
            //Arrange y Act
            var result = FizzBuzz.GetFizzBuzz(number);
            //Assert
            Assert.That(result, Is.EqualTo(resultFb));
        }
    }
}
