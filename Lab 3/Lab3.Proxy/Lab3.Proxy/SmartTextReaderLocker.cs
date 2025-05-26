using System;

namespace Lab3.Proxy
{
    // Проксі, що синхронізує доступ до читача
    public class SmartTextReaderLocker : ITextReader
    {
        private readonly ITextReader _inner;
        private readonly object _lock = new object();

        public SmartTextReaderLocker(ITextReader inner) => _inner = inner;

        public string Read()
        {
            lock (_lock)
            {
                Console.WriteLine("Отримуємо доступ до читання файлу...");
                var result = _inner.Read();
                Console.WriteLine("Читання завершено.");
                return result;
            }
        }
    }
}
