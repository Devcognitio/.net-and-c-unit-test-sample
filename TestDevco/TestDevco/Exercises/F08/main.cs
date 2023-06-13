namespace TestDevco.Exercises.F08
{
    public class main
    {

        public void Main()
        {
            var objFileReader = new FileReader();
            // var objFileReader = new FakeFileReader();
            var objBeerService = new BeerService(objFileReader);
            objBeerService.ReadBeer();
        }

    }
}
