using TestDevco.Exercises.F04;

namespace TestDevco.UnitTets.Exercises.F04
{
    [TestFixture]
    public class ProcessListsTests
    {
        [Test]
        //[TestCase(10, [0,2,4,6,8,10])]
        //[TestCase(4, [0,2,4])]
        public void GetEvenNumbers_LimitIsGreaterThanZero_RerturnEvenNumbersUpToLimit()
        {
            // Arrange
            var objProcessList = new ProcessLists();

            // Act
            var result = objProcessList.GetEvenNumbers(10);

            // Asserts
            /*Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(6)); // [0 2 4 6 8 10]
            Assert.That(result, Does.Contain(2));
            Assert.That(result, Does.Not.Contain(22));
            Assert.That(result, Does.Not.Contain(1));*/
            Assert.That(result, Is.EquivalentTo(new[] { 0, 2, 4, 6, 8, 10 }));

            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);

        }

    }
}
