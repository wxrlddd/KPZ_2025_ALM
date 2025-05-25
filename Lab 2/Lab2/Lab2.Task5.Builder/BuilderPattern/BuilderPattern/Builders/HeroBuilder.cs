namespace BuilderPattern.Builders
{
    public abstract class HeroBuilder
    {
        protected Hero hero = new Hero();

        public abstract HeroBuilder SetHeight();
        public abstract HeroBuilder SetStatus();
        public abstract HeroBuilder SetHairColor();
        public abstract HeroBuilder SetEyeColor();
        public abstract HeroBuilder SetClothes();
        public abstract HeroBuilder SetInventory();

        public Hero Build() => hero;
    }
}