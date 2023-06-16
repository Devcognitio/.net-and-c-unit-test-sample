using NUnit.Framework.Internal;
using TestDevco.Exercises.F06;

namespace TestDevco.UnitTets.Exercises.F06
{
    [TestFixture]
    public class HistoryTests
    {
        [Test]
        public void AddMsg_WhenCalled_SetTheLastMsgProperty()
        {
            var objHistory = new History();

            objHistory.AddMsg("abc");

            Assert.That(objHistory.LastMsg, Is.EqualTo("abc"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("    ")]
        public void AddMsg_InvalidError_ThrowArgumentNullException(string msgError)
        {
            // Arrange
            var objHistory = new History();

            // Act and Assert
            Assert.That(() => objHistory.AddMsg(msgError), Throws.TypeOf<ArgumentNullException>());
            //Assert.That(() => objHistory.AddMsg(msgError), Throws.ArgumentNullException);
            //Assert.Throws<ArgumentNullException>(() => objHistory.AddMsg(""));
        }


        [Test]
        public void AddMsg_ValidError_RaisedIdMsgRegisteredEvent()
        {
            // Arrange
            var objHistory = new History();
            var id = Guid.Empty;
            objHistory.IdMsgRegistered += (sender, args) => {
                id = args;
            };

            objHistory.AddMsg("abc");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }


        /*[Test]
        public void RaiseMsgEvent_WhenCalled_RaisedIdMsg()
        {
            var objHistory = new History();
            var id = Guid.Empty;
            objHistory.IdMsgRegistered += (sender, args) => {
                id = args;
            };

            var guid = Guid.NewGuid();
            objHistory.RaiseMsgEvent(guid); // private

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }*/
    }
}
