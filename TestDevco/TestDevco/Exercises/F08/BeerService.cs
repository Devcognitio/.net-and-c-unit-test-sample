using Newtonsoft.Json;

namespace TestDevco.Exercises.F08
{
    public class BeerService
    {
        
        public string ReadBeers()
        {
            var str = File.ReadAllText("corona.txt");
            var objBeer = JsonConvert.DeserializeObject<Beer>(str);
            if (objBeer == null)
                return "Error getting beer specification.";
            return objBeer.Title;
        }

    }

    public class Beer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal PercentageAlcohol { get; set; }
    }
}