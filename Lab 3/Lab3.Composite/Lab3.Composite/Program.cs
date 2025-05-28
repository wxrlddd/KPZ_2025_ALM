using System;
using System.Text;

namespace Lab3.Composite
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // існуючий приклад
            var root = new LightElementNode("div", false, new[] { "container" });
            var p = new LightElementNode("p");
            root.AddChild(p);
            p.AddChild(new LightTextNode("Привіт, світ!"));

            // новий елемент Image
            var imgLocal = new LightImageNode(@"C:\pictures\photo.jpg");
            var imgWeb = new LightImageNode("https://site.com/pic.png");

            root.AddChild(imgLocal);
            root.AddChild(imgWeb);

            Console.WriteLine("=== HTML ===");
            Console.WriteLine(root.OuterHTML());
            Console.WriteLine();

            Console.WriteLine("=== Simulate image loading ===");
            imgLocal.Load();
            imgWeb.Load();
        }
    }
}
