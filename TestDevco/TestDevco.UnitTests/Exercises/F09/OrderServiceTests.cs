using Moq;
using TestDevco.Exercises.F09;

namespace TestDevco.UnitTests.Exercises.F09
{
    [TestFixture]
    public class OrderServiceTests
    {

        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var mockStorage = new Mock<IStorage>();
            var objOrderService = new OrderService(mockStorage.Object);
            var objOrder = new Order();

            objOrderService.PlaceOrder(objOrder);

            mockStorage.Verify(s => s.Store(objOrder));
        }


    }
}
