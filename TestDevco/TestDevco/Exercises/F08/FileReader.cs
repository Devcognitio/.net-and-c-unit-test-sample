namespace TestDevco.Exercises.F08
{
    public class FileReader : IFileReader // PASO 2
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
