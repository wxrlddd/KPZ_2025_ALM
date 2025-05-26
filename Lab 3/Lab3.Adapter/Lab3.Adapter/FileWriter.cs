using System.IO;

namespace Lab3.Adapter
{
    public interface IWriter
    {
        void WriteLine(string text);
    }

    public class FileWriter : IWriter
    {
        private readonly string _path;
        public FileWriter(string path) => _path = path;
        public void WriteLine(string text)
            => File.AppendAllText(_path, text + System.Environment.NewLine);
    }
}