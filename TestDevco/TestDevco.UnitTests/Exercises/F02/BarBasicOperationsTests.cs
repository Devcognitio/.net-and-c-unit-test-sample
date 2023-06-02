using TestDevco.Exercises.F02;

namespace TestDevco.UnitTests.Exercises.F02
{
    [TestFixture]
    public class BarBasicOperationsTests
    {
        [Test]
        public void Sum_SumValues_ReturnSumValue()
        {
            var objBarBasicOperations = new BarBasicOperations();

            var result = objBarBasicOperations.Sum(1, 2);

            Assert.That(result, Is.EqualTo(3));
            Assert.That(result == 3);
        }
    }
}
