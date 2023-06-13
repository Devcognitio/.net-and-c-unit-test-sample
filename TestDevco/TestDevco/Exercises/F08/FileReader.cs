namespace TestDevco.Exercises.F08
{
    /*public interface IFileReader
    {
        string Read(string path);
    }*/

    public class FileReader : IFileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }

    /*public class FakeFileReader: IFileReader
    {
        public string Read(string path)
        {
            return "{ Id: 1, title: poker .... }";
        }
    }*/
}
