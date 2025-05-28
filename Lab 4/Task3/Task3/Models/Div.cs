using System;

namespace Lab4.Task3.Models
{
    public class Div : Element
    {
        public Div() : base("div") { }

        public void MouseOver()
        {
            Console.WriteLine($"{this}: подія MouseOver");
            DispatchEvent("mouseover");
        }
    }
}
