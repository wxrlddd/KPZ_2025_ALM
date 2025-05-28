using System;

namespace Lab3.Adapter
{
    public class FileLoggerAdapter : Logger
    {
        private readonly IWriter _writer;
        public FileLoggerAdapter(IWriter writer) => _writer = writer;

        public override void Log(string message)
            => _writer.WriteLine("[INFO] " + message);

        public override void Warn(string message)
            => _writer.WriteLine("[WARN] " + message);

        public override void Error(string message)
            => _writer.WriteLine("[ERROR] " + message);
    }
}
