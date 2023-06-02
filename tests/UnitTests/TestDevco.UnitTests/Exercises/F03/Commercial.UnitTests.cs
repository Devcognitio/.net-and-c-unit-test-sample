using TestDevco.Exercises.F03;

namespace TestDevco.UnitTests.Exercises.F03
{
    [TestFixture]
    public class CommercialTests
    {
        [Test]
        public void GetCommercialText_WhenCalled_ShouldReturnTextIncludingBeer()
        {
            // Arrange
            const string beerName = "Club Colombia";

            // Act
            string result = Commercial.GetCommercialText(beerName);

            // Assert
            Assert.That(result, Does.Contain(beerName));
            Assert.That(result, Does.StartWith("La "));
            Assert.That(result, Does.EndWith("."));
        }
    }
}