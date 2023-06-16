using TestDevco.Exercises.F02;

namespace TestDevco.UnitTets.Exercises.F02
{
    [TestFixture]
    public class BarBasicOperationsTests
    {
        private BarBasicOperations _barBasicOperations;// = new BarBasicOperations();

        [SetUp] 
        public void SetUp() {
            _barBasicOperations = new BarBasicOperations();
        }

        /*[TearDown]
        public void TearDown()
        {
            
        }*/

        [Test]
        //[Ignore("Por que estoy refactorizando!")]
        public void Sum_WhenCalled_ReturnTheSumOfArgs()
        {
            // Act
            var result = _barBasicOperations.Sum(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
            //Assert.That(1 == 1);
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
        public void MinValue_SameValue_ReturnMinValue()
        {
            //_barBasicOperations.Valor += 1;
            var result = _barBasicOperations.MinValue(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        [TestCase(1, 2, 1)]
        [TestCase(2, 1, 1)]
        [TestCase(1, 1, 1)]
        public void MinValue_WhenCalled_ReturnMinValue(int a, int b, int res)
        {
            var result = _barBasicOperations.MinValue(a, b);
            Assert.That(result, Is.EqualTo(res));
        }

    }
}
