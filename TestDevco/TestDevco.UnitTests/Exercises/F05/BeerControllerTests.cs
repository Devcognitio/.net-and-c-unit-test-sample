using TestDevco.Exercises.F05;
using static TestDevco.Exercises.F05.BeerController;

namespace TestDevco.UnitTests.Exercises.F05
{
    [TestFixture]
    public class BeerControllerTests
    {
        [Test]
        public void GetBeer_IdIsZero_ReturnNotFound()
        {
            var objController = new BeerController();

            var result = objController.GetBeer(0);

            // Not Found
            Assert.That(result, Is.TypeOf<NotFound>());
            // Not found or one of its derivatives
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetBeer_IdIsNotZero_ReturnOk()
        {
            var objController = new BeerController();

            var result = objController.GetBeer(1);

            // OK
            //Assert.That(result, Is.TypeOf<Ok>());
            // General
            //Assert.That(result, Is.InstanceOf<ActionResult>());
            Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}
