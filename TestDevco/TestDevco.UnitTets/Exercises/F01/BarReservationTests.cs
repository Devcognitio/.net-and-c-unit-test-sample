using TestDevco.Exercises.F01;

namespace TestDevco.UnitTets.Exercises.F01
{
    [TestFixture]
    public class BarReservationTests
    {
        // NombreDelMetodo_Escenario_ResultadoEsperado

        [Test]
        public void CanUpdateReservation_AdminUpdating_ReturnTrue()
        {
            // triple A --> Arrange (organizar el escenario), Act (Actuar), Assert (Afirmaciones)

            // Arrage
            var objReservation = new BarReservation();
            var adminUser = new User { IsAdmin = true };

            // Act
            var result = objReservation.CanUpdateReservation(adminUser);

            // Asserts
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
            //Assert.That(result == true);
            //Assert.That (objReservation, Is.TypeOf<BarReservation>());
        }

        [Test]
        public void CanUpdateReservation_SameUserUpdating_ReturnTrue()
        {
            var user = new User();
            var objReservation = new BarReservation();
            objReservation.MadeBy = user;

            var result = objReservation.CanUpdateReservation(user);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanUpdateReservation_OtherUserUpdating_ReturnFalse()
        {
            var user = new User();
            var objReservation = new BarReservation();

            var result = objReservation.CanUpdateReservation(user);

            Assert.That(result, Is.False);
            Assert.IsFalse(result);
        }

    }
}
