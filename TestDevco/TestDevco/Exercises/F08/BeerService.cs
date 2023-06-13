using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace TestDevco.Exercises.F08
{
    public class BeerService
    {
        //public IFileReader fileReaderProp { get; set; }  // segundo caso
        private IFileReader _fileReader;

        public BeerService(IFileReader fileReader) {  // tercer caso (mejor caso)
            this._fileReader = fileReader;
        }

        //public string ReadBeers(IFileReader fileReader)  // primer caso
        public string ReadBeer()
        {
            //var str = File.ReadAllText("corona.txt");
            //var str = new FileReader().Read("corona.txt"); // Sigue acoplado
            var str = this._fileReader.Read("corona.txt");
            var objBeer = JsonConvert.DeserializeObject<Beer>(str);
            if (objBeer == null)
                return "Error getting beer specification.";
            return objBeer.Title;
        }


        public string GetBeersAsCsv()
        {
            var beerIds = new List<int>();

            using (var context = new BeerContext())
            {
                var beers = (from beer in context.Beers where beer.PercentageAlcohol >= 0.5M select beer).ToList();

                foreach (var b in beers)
                    beerIds.Add(b.Id);

                return String.Join(",", beerIds);
            }
        }
    }

    public class Beer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal PercentageAlcohol { get; set; }
    }

    public class BeerContext : DbContext
    {
        public DbSet<Beer> Beers { get; set; }
    }
}