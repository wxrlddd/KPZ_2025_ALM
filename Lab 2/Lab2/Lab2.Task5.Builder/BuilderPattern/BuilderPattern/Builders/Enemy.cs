using System;

namespace BuilderPattern.Builders
{
    public class Enemy
    {
        public string Type { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public void DisplayEnemy()
        {
            Console.WriteLine($"Ворог — Тип: {Type}, Рівень: {Level}, Здоров’я: {Health}, Урон: {Damage}");
        }
    }
}
