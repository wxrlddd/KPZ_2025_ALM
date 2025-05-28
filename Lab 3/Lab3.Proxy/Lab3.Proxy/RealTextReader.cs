using System.IO;

namespace Lab3.Proxy
{
    public class RealTextReader : ITextReader
    {
        private readonly string _path;
        public RealTextReader(string path) => _path = path;

        public string Read()
        {
            return File.ReadAllText(_path);
        }
    }
}
