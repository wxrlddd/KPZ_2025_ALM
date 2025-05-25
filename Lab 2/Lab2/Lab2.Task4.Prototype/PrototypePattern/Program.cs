using System;
using PrototypePattern.Prototypes;

namespace PrototypePattern
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Завдання 4: Патерн Прототип ===");

            var family = new VirusFamily();
            family.ShowAvailableTypes();

            Console.WriteLine("\nОригінал COVID-19:");
            var original = family.CloneVirus("COVID-19");
            original.DisplayInfo();

            Console.WriteLine("\nКлон COVID-19:");
            var clone = original.Clone();
            clone.Name = "COVID-19 (клон)";
            clone.Age = 5;
            clone.DisplayInfo();

            Console.WriteLine($"\nЧи різні об’єкти? {!ReferenceEquals(original, clone)}");
        }
    }
}
