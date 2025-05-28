using System;
using Lab4.Task3.Models;

namespace Lab4.Task3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var btn = new Button();
            var div = new Div();

            btn.AddEventListener("click", () => Console.WriteLine("Обробник: кнопка натиснута!"));
            btn.AddEventListener("click", () => Console.WriteLine("Інший слухач: click отримано."));
            div.AddEventListener("mouseover", () => Console.WriteLine("Обробник: миша над блоком!"));

            Console.WriteLine("=== Клік по кнопці ===");
            btn.Click();

            Console.WriteLine("\n=== Наведення миші на div ===");
            div.MouseOver();
        }
    }
}
