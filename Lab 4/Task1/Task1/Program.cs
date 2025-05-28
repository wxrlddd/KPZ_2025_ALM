using System;
using Lab4.Task1.Handlers;

namespace Lab4.Task1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

           
            var h1 = new LevelOneHandler();
            var h2 = new LevelTwoHandler();
            var h3 = new LevelThreeHandler();
            var h4 = new LevelFourHandler();
            h1.SetNext(h2);
            h2.SetNext(h3);
            h3.SetNext(h4);

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("=== Меню підтримки ===");
                Console.WriteLine("Введіть рівень підтримки (1–4)");
                Console.WriteLine("Або введіть 0, щоб вийти");
                Console.Write("Ваш вибір: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "0")
                {
                    exit = true;
                    break;
                }

                if (!int.TryParse(input, out int lvl))
                {
                    Console.WriteLine("Некоректне значення. Слід ввести число від 0 до 4.");
                    continue;
                }

                if (lvl >= 1 && lvl <= 4)
                {
                    h1.Handle(lvl);
                }
                else
                {
                    Console.WriteLine("Немає відповідного рівня підтримки. Спробуйте ще раз.");
                    continue;
                }

                
                Console.WriteLine();
                Console.Write("Бажаєте вибрати інший рівень? (y/n): ");
                string again = Console.ReadLine()?.Trim().ToLower();
                if (again != "y" && again != "так")
                {
                    exit = true;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Дякуємо, гарного дня!");
        }
    }
}
