namespace TestDevco.Exercises.F04;

public static class ProcessLists
{
    public static IEnumerable<int> GetEvenNumbers(int limit)
    {
        for (var i = 0; i <= limit; i++)
        {
            if (i % 2 == 0)
                yield return i;
        }
    }
}
