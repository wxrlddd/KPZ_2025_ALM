using System;
using System.Text;

namespace Lab3.Composite
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Створюємо кореневий <div class="container">
            var root = new LightElementNode("div", isSelfClosing: false, cssClasses: new[] { "container" });

            // Додаємо абзац з текстом
            var p = new LightElementNode("p");
            p.AddChild(new LightTextNode("Привіт, світ!"));
            root.AddChild(p);

            // Додаємо self-closing зображення
            var img = new LightElementNode("img", isSelfClosing: true, cssClasses: new[] { "img-responsive", "rounded" });
            root.AddChild(img);

            // Виводимо результат
            Console.WriteLine("=== outerHTML кореня ===");
            Console.WriteLine(root.OuterHTML());
            Console.WriteLine();
            Console.WriteLine("=== innerHTML кореня ===");
            Console.WriteLine(root.InnerHTML());
        }
    }
}