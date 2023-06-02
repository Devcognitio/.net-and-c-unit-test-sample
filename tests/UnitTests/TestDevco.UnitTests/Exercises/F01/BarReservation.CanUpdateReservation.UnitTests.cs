using TestDevco.Exercises.F01;

namespace TestDevco.UnitTests.Exercises.F01;

[TestFixture]
public class BarReservationTests
{
    [Test]
    public void CanUpdateReservation_WhenUserIsAdmin_ShouldReturnTrue()
    {
        // Arrange
        User admin = new() { IsAdmin = true };
        User user = new();
        BarReservation reservation = new(user);

        // Act
        bool result = reservation.CanUpdateReservation(admin);

        // Assert
        Assert.That(result);
    }

    [Test]
    public void CanUpdateReservation_WhenUserIsCreator_ShouldReturnTrue()
    {
        // Arrange
        User creator = new();
        BarReservation reservation = new(creator);

        // Act
        bool result = reservation.CanUpdateReservation(creator);

        // Assert
        Assert.That(result);
    }

    [Test]
    public void CanUpdateReservation_WhenUserIsNotAdminNorCreator_ShouldReturnFalse()
    {
        // Arrange
        User someUser = new();
        User creator = new();
        BarReservation reservation = new(creator);

        // Act
        bool result = reservation.CanUpdateReservation(someUser);

        // Assert
        Assert.That(!result);
    }

    [Test]
    public void CanUpdateReservation_WhenNoUserIsPassed_ShouldThrowException()
    {
        // Arrange
        User? creator = null;
        BarReservation reservation = new(new());

        // Act
        void TestDelegate() => reservation.CanUpdateReservation(creator!);

        // Assert
        Assert.Throws<ArgumentNullException>(TestDelegate);
    }
}