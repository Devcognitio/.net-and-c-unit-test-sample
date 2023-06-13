using Moq;
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

        [Test]
        public void ReadBeer_EmptyFileWithMock_ReturnError()
        {
            // Arrange
            var mockFileReader = new Mock<IFileReader>();
            //mockFileReader.Setup(mfr => mfr.Read("corona.txt")).Returns("");
            //mockFileReader.Setup(mfr => mfr.Read(It.IsAny<string>())).Returns("");
            mockFileReader.Setup(mfr => mfr.Read(It.IsAny<string>())).Returns((string path) =>
            {
                string path2 = $"{path}/tmp";
                // do something with path2
                // ...
                // ...
                return "";
            });
            var objBeerService = new BeerService(mockFileReader.Object);

            // Act
            var result = objBeerService.ReadBeer();

            // Asserts
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }


        [Test]
        public void GetBeersAsCsv_AFewBeers_RerturnBeerIds()
        {
            var mockFileReader = new Mock<IFileReader>();
            var mockBeerRepo = new Mock<IBeerRepository>();
            mockBeerRepo.Setup(r => r.GetBeerWithMoreThan5Perc()).Returns(new List<Beer>()
            {
                new Beer { Id = 1 },
                new Beer { Id = 2 },
                new Beer { Id = 3 },
            });
            var objBeerService = new BeerService(mockFileReader.Object, mockBeerRepo.Object);

            var result = objBeerService.GetBeersAsCsv();

            Assert.That(result, Is.EqualTo("1,2,3"));
        }

    }
}
