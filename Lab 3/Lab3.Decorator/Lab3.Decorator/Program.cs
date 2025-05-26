using System;
using System.Text;

namespace Lab3.Decorator
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            IHero hero = new Warrior();
            hero = new WeaponDecorator(hero, "Меч");
            hero = new ArmorDecorator(hero, "Латний обладунок");
            hero = new ArtifactDecorator(hero, "Кулон сили");
            hero = new ArtifactDecorator(hero, "Книга заклять");

            Console.WriteLine(hero.GetDescription());
        }
    }
}