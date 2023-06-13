namespace TestDevco.Exercises.F08
{
    public class BeerRepository : IBeerRepository
    {
        public IEnumerable<Beer> GetBeerWithMoreThan5Perc()
        {
            using (var context = new BeerContext())
            {
                var beers = (from beer in context.Beers where beer.PercentageAlcohol >= 0.5M select beer).ToList();
                return beers;
            }

        }
    }

    public interface IBeerRepository
    {
        IEnumerable<Beer> GetBeerWithMoreThan5Perc();
    }

}
