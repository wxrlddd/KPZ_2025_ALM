using System;
using System.Collections.Generic;

namespace BuilderPattern.Builders
{
    public class Hero
    {
        public int Height { get; set; }
        public int Status { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothes { get; set; }
        public List<string> Inventory { get; } = new List<string>();

        public void DisplayHero()
        {
            Console.WriteLine($"Герой — Зріст: {Height} см, Статус: {Status}");
            Console.WriteLine($"Колір волосся: {HairColor}, Колір очей: {EyeColor}");
            Console.WriteLine($"Одяг: {Clothes}");
            if (Inventory.Count > 0)
                Console.WriteLine($"Інвентар: {string.Join(", ", Inventory)}");
        }
    }
}
