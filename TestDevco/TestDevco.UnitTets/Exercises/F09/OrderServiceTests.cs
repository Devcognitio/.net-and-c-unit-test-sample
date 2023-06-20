using Moq;
using TestDevco.Exercises.F09;

namespace TestDevco.UnitTets.Exercises.F09
{
    [TestFixture]
    public class OrderServiceTests
    {
        // Prueba basada en estado
        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            // Arrange
            var mockStorage = new Mock<IStorage>();
            mockStorage.Setup(fr => fr.Store(It.IsAny<object>())).Returns(1);
            //mockStorage.Setup(fr => fr.Store(It.IsAny<object>())).Throws<InvalidOperationException>();

            var objOrderService = new OrderService(mockStorage.Object);
            var objOrder = new Order();

            // Act
            var result = objOrderService.PlaceOrder(objOrder);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        // Prueba basada en interacción
        [Test]
        public void PlaceOrder_WhenCalled_CheckStoreMethod()
        {
            var mockStorage = new Mock<IStorage>();
            var objOrderService = new OrderService(mockStorage.Object);
            var objOrder = new Order() { Title = "123" };
            //var objOrder2 = new Order() { Title = "123" };

            objOrderService.PlaceOrder(objOrder);

            mockStorage.Verify(s => s.Store(objOrder));
            //mockStorage.Verify(s => s.Store(objOrder2));
            //mockStorage.Verify(s => s.Store(It.IsAny<Order>()));
        }



    }
}
