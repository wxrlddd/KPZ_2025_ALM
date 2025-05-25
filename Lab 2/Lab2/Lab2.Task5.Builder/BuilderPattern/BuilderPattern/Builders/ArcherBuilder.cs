namespace BuilderPattern.Builders
{
    public class ArcherBuilder : HeroBuilder
    {
        public override HeroBuilder SetHeight()
        {
            hero.Height = 175;
            return this;
        }

        public override HeroBuilder SetStatus()
        {
            hero.Status = 90;
            return this;
        }

        public override HeroBuilder SetHairColor()
        {
            hero.HairColor = "Русий";
            return this;
        }

        public override HeroBuilder SetEyeColor()
        {
            hero.EyeColor = "Зелені";
            return this;
        }

        public override HeroBuilder SetClothes()
        {
            hero.Clothes = "Шкіряна броня";
            return this;
        }

        public override HeroBuilder SetInventory()
        {
            hero.Inventory.AddRange(new[] { "Лук", "Колчан зі стрілами", "Кинджал" });
            return this;
        }
    }
}