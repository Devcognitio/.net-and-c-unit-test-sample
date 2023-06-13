using TestDevco.Exercises.F08;

namespace TestDevco.UnitTests.Exercises.F08
{
    public class FakeFileReaderEmpty : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
