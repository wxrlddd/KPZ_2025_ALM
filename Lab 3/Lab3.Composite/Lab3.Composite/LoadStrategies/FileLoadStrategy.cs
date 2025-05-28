using System;

namespace Lab3.Composite.LoadStrategies
{
    public class FileLoadStrategy : ILoadStrategy
    {
        public void Load(string href)
        {
            Console.WriteLine($"[File] Завантаження з файлової системи: {href}");
        }
    }
}
