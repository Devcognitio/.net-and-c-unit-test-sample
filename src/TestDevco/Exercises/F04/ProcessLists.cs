namespace TestDevco.Exercises.F04
{
    public class ProcessLists
    {
        public IEnumerable<int> GetEvenNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 == 0)
                    yield return i;
        }

    }
}
