using System;

namespace Lab4.Task3.Models
{
    public class Button : Element
    {
        public Button() : base("button") { }

        public void Click()
        {
            Console.WriteLine($"{this}: подія Click");
            DispatchEvent("click");
        }
    }
}
