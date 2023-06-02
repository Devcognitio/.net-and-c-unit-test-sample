using Newtonsoft.Json;

namespace TestDevco.Exercises.F08;

public static class BeerService
{
    public static string ReadBeers()
    {
        string beerData = File.ReadAllText("corona.txt");
        Beer beerSpecification = JsonConvert.DeserializeObject<Beer>(beerData)!;
        if (beerSpecification is null)
            return "Error getting beer specification.";
        return beerSpecification.Title ?? "No beer title";
    }
}

public class Beer
{
    public int Id { get; }
    public string? Title { get; }
    public decimal PercentageAlcohol { get; }
}