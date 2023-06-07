using TestDevco.Exercises.F03;

namespace TestDevco.UnitTests.Exercises.F03
{
    [TestFixture]
    public class CommercialTests
    {
        [Test]
        public void CommercialText_WhenCalled_ReturnTextWithBeer()
        {
            var commercial = new Commercial();

            var text = commercial.CommercialText("Aguila");

            // specific
            Assert.That(text, Is.EqualTo("la Aguila es la mejor cerveza del mundo"));

            // general
            /*Assert.That(text, Does.StartWith("la"));
            Assert.That(text, Does.Contain("Aguila").IgnoreCase);
            Assert.That(text, Does.EndWith(" es la mejor cerveza del mundo"));*/
        }
    }
}
