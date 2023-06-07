using TestDevco.Exercises.F06;

namespace TestDevco.UnitTests.Exercises.F06
{
    [TestFixture]
    public class HistoryTests
    {
        private History _history;

        [SetUp]
        public void SetUp()
        {
            _history = new History();
        }

        [Test]
        public void AddMsg_WheCalledWithNotEmptyValue_ReturnLastMsg()
        {
            string msg = "error_1";

            _history.AddMsg(msg);

            Assert.That(_history.LastMsg, Is.EqualTo(msg));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void AddMsg_InvalidError_ThrowArgumentNullException(string error)
        {
            //Assert.That(() => _history.AddMsg(error), Throws.TypeOf<ArgumentNullException>());
            Assert.That(() => _history.AddMsg(error), Throws.ArgumentNullException);
        }

        [Test]
        public void AddMsg_ValidError_RaiseIdMsgRegisteredEvent()
        {
            var id = Guid.Empty;
            _history.IdMsgRegistered += (sender, args) =>
            {
                id = args;
            };

            _history.AddMsg("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }

        [Test]
        public void RaiseMsgEvent_WhenCalled_RaiseEvent()
        {
            var id = Guid.Empty;
            _history.IdMsgRegistered += (sender, args) =>
            {
                id = args;
            };

            _history.RaiseMsgEvent(Guid.NewGuid());

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }


    }
}
