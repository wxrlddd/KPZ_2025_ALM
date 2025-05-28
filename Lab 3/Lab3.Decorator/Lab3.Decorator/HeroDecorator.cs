namespace Lab3.Decorator
{
    public abstract class HeroDecorator : IHero
    {
        protected readonly IHero Hero;
        protected readonly string ItemName;
        protected HeroDecorator(IHero hero, string itemName)
        {
            Hero = hero;
            ItemName = itemName;
        }

        public virtual string GetDescription()
            => Hero.GetDescription() + ", " + ItemName;
    }
}