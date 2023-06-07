using TestDevco.Exercises.F02;

namespace TestDevco.UnitTests.Exercises.F02
{
    [TestFixture]
    public class BarBasicOperationsTests
    {
        private BarBasicOperations _barBasicOperations;// = new BarBasicOperations(); 

        [SetUp]
        public void SetUp()
        {
            _barBasicOperations = new BarBasicOperations();
        }

        /*
        [TearDown]
        public void TearDown()
        {
            
        }*/

        [Test]
        //[Ignore("Por que estory cambiando el codigo de prod")]
        public void Sum_SumValues_ReturnSumValue()
        {
            //_barBasicOperations.Valor += 1;
            var result = _barBasicOperations.Sum(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }


        [Test]
        public void MinValue_FirstParamIsMinValue_ReturnFirstParam()
        {
            //_barBasicOperations.Valor += 1;
            var result = _barBasicOperations.MinValue(1, 2);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void MinValue_SecondParamIsMinValue_ReturnSecondParam()
        {
            //_barBasicOperations.Valor += 1;
            var result = _barBasicOperations.MinValue(2, 1);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void MinValue_SameParamIsMinValue_ReturnSameParam()
        {
            //_barBasicOperations.Valor += 1;
            var result = _barBasicOperations.MinValue(1, 1);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 1)]
        [TestCase(2, 1, 1)]
        public void MinValue_WhenCalled_ShouldRerturnMinValue(int a, int b, int res)
        {
            var result = _barBasicOperations.MinValue(a, b);

            Assert.That(result, Is.EqualTo(res));
        }


    }
}
