using System;
using System.IO;
using System.Text;

namespace Lab3.Adapter
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            
            var consoleLogger = new Logger();
            consoleLogger.Log("Це просте повідомлення інформації");
            consoleLogger.Warn("Це попередження");
            consoleLogger.Error("Це повідомлення про помилку");

            
            string path = "log.txt";
            IWriter fileWriter = new FileWriter(path);
            var fileLogger = new FileLoggerAdapter(fileWriter);
            fileLogger.Log("Початок запису в файл");
            fileLogger.Warn("Тут може бути попередження");
            fileLogger.Error("Щось пішло не так");

            
            Console.WriteLine(File.Exists(path)
                ? $"Файл знайдено: {Path.GetFullPath(path)}"
                : "Файл НЕ знайдено");
        }
    }
}