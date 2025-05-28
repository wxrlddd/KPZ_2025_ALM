using System;
using System.Linq;
using System.Text;

namespace Lab3.Flyweight
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var lines = new[]
            {
                "Гамлет, принц Данії.",
                "Короткий рядок",
                "    Цитата знайомого автора.",
                "Це довгий рядок, що перевищує двадцять символів і тому стане параграфом."
            };

            
            var sharedEmptyClasses = FlyweightFactory.GetClassList(null);

            
            GC.Collect();
            var before = GC.GetTotalMemory(true);
            var plain = BuildHtmlTree(lines, useFW: false, sharedEmptyClasses);
            GC.Collect();
            var after = GC.GetTotalMemory(true);

            Console.WriteLine("=== Без Flyweight ===");
            Console.WriteLine(plain.OuterHTML());
            Console.WriteLine(plain.InnerHTML());
            Console.WriteLine($"Пам’ять зайнято: {after - before:N0} байт\n");

           
            GC.Collect();
            var fwBefore = GC.GetTotalMemory(true);
            var fw = BuildHtmlTree(lines, useFW: true, sharedEmptyClasses);
            GC.Collect();
            var fwAfter = GC.GetTotalMemory(true);

            Console.WriteLine("=== З Flyweight ===");
            Console.WriteLine(fw.OuterHTML());
            Console.WriteLine(fw.InnerHTML());
            Console.WriteLine($"Пам’ять зайнято: {fwAfter - fwBefore:N0} байт");
        }

        static LightElementNode BuildHtmlTree(string[] lines, bool useFW,
                                              System.Collections.Generic.List<string> sharedEmpty)
        {
            var root = new LightElementNode(
                useFW ? FlyweightFactory.GetTag("div") : "div",
                false,
                useFW ? sharedEmpty : null
            );

            foreach (var line in lines)
            {
                string tag = line == lines.First() ? "h1"
                           : line.Length < 20 ? "h2"
                           : char.IsWhiteSpace(line, 0) ? "blockquote"
                           : "p";

                var elem = new LightElementNode(
                    useFW ? FlyweightFactory.GetTag(tag) : tag,
                    false,
                    useFW ? sharedEmpty : null
                );

                elem.AddChild(new LightTextNode(line));
                root.AddChild(elem);
            }

            return root;
        }
    }
}
