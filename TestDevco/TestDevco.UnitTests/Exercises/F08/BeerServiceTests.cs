using TestDevco.Exercises.F08;

namespace TestDevco.UnitTests.Exercises.F08
{
    [TestFixture]
    public class BeerServiceTests
    {
        [Test]
        public void ReadBeer_EmptyFile_ReturnError()
        {
            // Arrange
            var objBeerService = new BeerService(new FakeFileReaderEmpty());

            // Act
            var result = objBeerService.ReadBeer();

            // Asserts
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

    }
}
