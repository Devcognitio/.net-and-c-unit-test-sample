using TestDevco.Exercises.F03;

namespace TestDevco.UnitTets.Exercises.F03
{
    [TestFixture]
    public class CommercialTests
    {
        [Test]
        public void CommercialText_WhenCalled_ReturnTextWithBeer()
        {
            var objCommercial = new Commercial();

            var text = objCommercial.CommercialText("Aguila");

            // Specific
            Assert.That(text, Is.EqualTo("la Aguila es la mejor cerveza del mundo"));

            // More General
            /*Assert.That(text, Does.StartWith("la "));
            Assert.That(text, Does.EndWith(" es la mejor cerveza del mundo"));
            Assert.That(text, Does.Contain("aguila").IgnoreCase);*/
        }

    }
}
