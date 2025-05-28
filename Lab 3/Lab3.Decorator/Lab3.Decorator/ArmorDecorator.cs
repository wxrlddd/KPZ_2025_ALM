namespace Lab3.Decorator
{
    public class ArmorDecorator : HeroDecorator
    {
        public ArmorDecorator(IHero hero, string armor)
            : base(hero, "Убраний: " + armor) { }
    }
}