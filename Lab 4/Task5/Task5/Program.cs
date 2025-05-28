using System;
using Lab4.Task5.Models;

namespace Lab4.Task5
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var editor = new TextEditor();

            Console.WriteLine("Пишемо «Hello»");
            editor.Type("Hello");
            Console.WriteLine(editor.Document.Content);

            Console.WriteLine("Пишемо «, world!»");
            editor.Type(", world!");
            Console.WriteLine(editor.Document.Content);

            Console.WriteLine("Undo");
            editor.Undo();
            Console.WriteLine(editor.Document.Content);

            Console.WriteLine("Undo");
            editor.Undo();
            Console.WriteLine(editor.Document.Content);
        }
    }
}
