namespace BuilderPattern.Builders
{
    public class WarriorBuilder : HeroBuilder
    {
        public override HeroBuilder SetHeight()
        {
            hero.Height = 185;
            return this;
        }

        public override HeroBuilder SetStatus()
        {
            hero.Status = 100;
            return this;
        }

        public override HeroBuilder SetHairColor()
        {
            hero.HairColor = "Коричневий";
            return this;
        }

        public override HeroBuilder SetEyeColor()
        {
            hero.EyeColor = "Карі";
            return this;
        }

        public override HeroBuilder SetClothes()
        {
            hero.Clothes = "Броня воїна";
            return this;
        }

        public override HeroBuilder SetInventory()
        {
            hero.Inventory.AddRange(new[] { "Меч", "Щит", "Зілля здоров'я" });
            return this;
        }
    }
}