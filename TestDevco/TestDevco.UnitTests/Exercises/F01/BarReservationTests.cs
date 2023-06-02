using TestDevco.Exercises.F01;

namespace TestDevco.UnitTests.Exercises.F01
{
    [TestFixture]
    public class BarReservationTests
    {
        [Test]
        public void CanUpdateReservation_AdminUpdating_ReturnTrue()
        {
            // Arrange (organizar)
            var objReservation = new BarReservation();
            var user = new User { IsAdmin = true };

            // Act
            var result = objReservation.CanUpdateReservation(user);

            // Assert
            Assert.IsTrue(result);
            Assert.That(result, Is.True);
            Assert.That(result == true);
        }

        [Test]
        public void CanUpdateReservation_SameUserUpdating_ReturnTrue()
        {
            var user = new User();
            var objReservation = new BarReservation() { MadeBy = user };

            var result = objReservation.CanUpdateReservation(user);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanUpdateReservation_OtherUserUpdating_RertunFalse()
        {
            var user = new User();
            var objReservation = new BarReservation();

            var result = objReservation.CanUpdateReservation(user);

            Assert.That(result, Is.False);
            //Assert.That(!result, Is.True);
        }

    }
}
