namespace TestDevco.Exercises.F08
{
    public class Main
    {
        public void MainMethod()
        {
            var objFileReader = new FileReader();
            var objBeerService = new BeerService(objFileReader);
            var result = objBeerService.ReadBeer();
            Console.WriteLine(result);
        }

    }
}
