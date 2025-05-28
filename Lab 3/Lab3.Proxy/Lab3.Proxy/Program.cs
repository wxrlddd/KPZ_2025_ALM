using System;
using System.IO;
using System.Text;

namespace Lab3.Proxy
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Готуємо тестовий файл
            string path = "sample.txt";
            File.WriteAllText(path, "Це тестовий текст без заборонених слів.");

            // Будуємо ланцюжок проксі
            ITextReader reader = new RealTextReader(path);
            reader = new SmartTextChecker(reader);
            reader = new SmartTextReaderLocker(reader);

            try
            {
                var content = reader.Read();
                Console.WriteLine("Зміст файлу:");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}
