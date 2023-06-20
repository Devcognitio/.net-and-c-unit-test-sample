using TestDevco.Exercises.F08;

namespace TestDevco.UnitTets.Exercises.F08
{
    internal class FakeFileReader2 : IFileReader
    {
        public string Read(string path)
        {
            return "                  ";
        }
    }
}
