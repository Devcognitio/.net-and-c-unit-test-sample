using TestDevco.Exercises.F05;
using static TestDevco.Exercises.F05.BeerController;

namespace TestDevco.UnitTets.Exercises.F05
{
    [TestFixture]
    public class BeerControllerTests
    {
        [Test]
        public void GetBeer_IdParamIsZero_ReturnNotFound()
        {
            var objBeerController = new BeerController();

            var result = objBeerController.GetBeer(0);

            // Not Found
            Assert.That(result, Is.TypeOf<NotFound>());

            // Not found or one of its derivatives
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetBeer_IdParamIsNotZero_ReturnOk()
        {
            var objBeerController = new BeerController();

            var result = objBeerController.GetBeer(1);

            // OK
            Assert.That(result, Is.TypeOf<Ok>());
        }

    }
}
