using System;
using BuilderPattern.Builders;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Завдання 5: Патерн Будівельник ===");

            var director = new GameDirector();

            Console.WriteLine("\nСтворення героїв:");

            var warrior = director.ConstructHero(new WarriorBuilder());
            Console.WriteLine("\nВоїн:");
            warrior.DisplayHero();

            var mage = director.ConstructHero(new MageBuilder());
            Console.WriteLine("\nМаг:");
            mage.DisplayHero();

            var archer = director.ConstructHero(new ArcherBuilder());
            Console.WriteLine("\nЛучник:");
            archer.DisplayHero();

            Console.WriteLine("\nСтворення ворогів:");

            var orc = director.ConstructEnemy(new OrcBuilder());
            Console.WriteLine("\nОрк:");
            orc.DisplayEnemy();

            var dragon = director.ConstructEnemy(new DragonBuilder());
            Console.WriteLine("\nДракон:");
            dragon.DisplayEnemy();
        }
    }
}
