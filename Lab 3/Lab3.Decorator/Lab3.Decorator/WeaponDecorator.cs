namespace Lab3.Decorator
{
    public class WeaponDecorator : HeroDecorator
    {
        public WeaponDecorator(IHero hero, string weapon)
            : base(hero, "Озброєний: " + weapon) { }
    }
}