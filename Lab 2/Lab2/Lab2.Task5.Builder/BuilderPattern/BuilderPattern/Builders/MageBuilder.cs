namespace BuilderPattern.Builders
{
    public class MageBuilder : HeroBuilder
    {
        public override HeroBuilder SetHeight()
        {
            hero.Height = 170;
            return this;
        }

        public override HeroBuilder SetStatus()
        {
            hero.Status = 80;
            return this;
        }

        public override HeroBuilder SetHairColor()
        {
            hero.HairColor = "Сріблястий";
            return this;
        }

        public override HeroBuilder SetEyeColor()
        {
            hero.EyeColor = "Блакитні";
            return this;
        }

        public override HeroBuilder SetClothes()
        {
            hero.Clothes = "Мантія мага";
            return this;
        }

        public override HeroBuilder SetInventory()
        {
            hero.Inventory.AddRange(new[] { "Магічний посох", "Книга заклинань", "Зілля мани" });
            return this;
        }
    }
}