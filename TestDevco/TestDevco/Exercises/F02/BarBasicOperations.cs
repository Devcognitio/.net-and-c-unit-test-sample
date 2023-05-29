namespace TestDevco.Exercises.F02
{
    public class BarBasicOperations
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int MinValue(int a, int b)
        {
            return (a < b) ? a : b;
        }

        public IEnumerable<int> GetEvenNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 == 0)
                    yield return i;
        }
    }
}
