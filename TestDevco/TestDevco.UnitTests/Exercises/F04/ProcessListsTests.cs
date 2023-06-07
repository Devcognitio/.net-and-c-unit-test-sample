using TestDevco.Exercises.F04;

namespace TestDevco.UnitTests.Exercises.F04
{
    [TestFixture]
    public class ProcessListsTests
    {
        [Test]
        public void GetEvenNumbers_LimitIsGreaterThanZero_ReturnEvenNumbersUpToLimit()
        {
            // Arrange
            var objProcessList = new ProcessLists();

            // Act
            var result = objProcessList.GetEvenNumbers(10);

            // Asserts
            /*Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(6)); //[1, 1, 1, 1, 1, 1]
            Assert.That(result, Does.Contain(4));
            Assert.That(result, Does.Not.Contain(20));
            Assert.That(result, Does.Not.Contain(5));*/
            Assert.That(result, Is.EquivalentTo(new[] { 0, 2, 4, 6, 8, 10 }));
        } 

    }
}
