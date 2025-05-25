using System;
using System.Collections.Generic;

namespace PrototypePattern.Prototypes
{
    public abstract class VirusPrototype
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public List<VirusPrototype> Children { get; set; } = new List<VirusPrototype>();

        public abstract VirusPrototype Clone();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Вірус: {Name}, Вік: {Age}, Тип: {Type}, Вага: {Weight}кг");
            foreach (var child in Children)
            {
                Console.Write("  → ");
                child.DisplayInfo();
            }
        }
    }
}
