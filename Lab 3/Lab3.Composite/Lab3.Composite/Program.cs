using System;
using System.Text;

namespace Lab3.Composite
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var root = new LightElementNode("div", false, new[] { "container" });
            var p = new LightElementNode("p");
            var img = new LightElementNode("img", true, new[] { "img-responsive", "rounded" });

            root.AddChild(p);
            p.AddChild(new LightTextNode("Привіт, світ!"));
            root.AddChild(img);

            root.AddEventListener("click", () => Console.WriteLine("Div: обробник click"));
            p.AddEventListener("mouseover", () => Console.WriteLine("P: обробник mouseover"));
            img.AddEventListener("click", () => Console.WriteLine("Img: клік по зображенню"));

            Console.WriteLine("=== outerHTML ===");
            Console.WriteLine(root.OuterHTML());
            Console.WriteLine("\n=== innerHTML ===");
            Console.WriteLine(root.InnerHTML());
            Console.WriteLine();

            Console.WriteLine("=== Симуляція подій ===");
            root.DispatchEvent("click");
            p.DispatchEvent("mouseover");
            img.DispatchEvent("click");
        }
    }
}
