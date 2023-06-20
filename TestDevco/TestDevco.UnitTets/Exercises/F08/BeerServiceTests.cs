using Moq;
using TestDevco.Exercises.F08;

namespace TestDevco.UnitTets.Exercises.F08
{
    [TestFixture]
    public class BeerServiceTests
    {

        [Test]
        public void ReadBeer_EmptyFile_ReturnErrorMsg()
        {
            var objBeerService = new BeerService(new FakeFileReader());
            var result = objBeerService.ReadBeer();
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

        [Test]
        public void ReadBeer_EmptyFileWithSpaces_ReturnErrorMsg()
        {
            var objBeerService = new BeerService(new FakeFileReader2());
            var result = objBeerService.ReadBeer();
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }


        [Test]
        public void ReadBeer_EmptyFileWithMoq_ReturnErrorMsg()
        {
            var count = 1;
            var mockFileReader = new Mock<IFileReader>();
            //mockFileReader.Setup(fr => fr.Read("corona.txt")).Returns("");
            //mockFileReader.Setup(fr => fr.Read(It.IsAny<string>())).Returns("");
            mockFileReader.Setup(fr => fr.Read(It.IsAny<string>())).Returns((string path) =>
            {
                string path2 = $"{path}/tmp";

                if (path == "corona.txt")
                {
                    count += 1;
                }
                // do something with path2
                // ...
                // ...
                // ...
                // ...

                return "";
            });

            var objBeerService = new BeerService(mockFileReader.Object);
            var result = objBeerService.ReadBeer();
            Assert.That(result, Does.Contain("error").IgnoreCase);
            Assert.That(count, Is.EqualTo(2));
        }


    }
}
