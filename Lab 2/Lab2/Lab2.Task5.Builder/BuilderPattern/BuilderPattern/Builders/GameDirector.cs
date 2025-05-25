namespace BuilderPattern.Builders
{
    public class GameDirector
    {
        public Hero ConstructHero(HeroBuilder builder)
        {
            return builder
                .SetHeight()
                .SetStatus()
                .SetHairColor()
                .SetEyeColor()
                .SetClothes()
                .SetInventory()
                .Build();
        }

        public Enemy ConstructEnemy(EnemyBuilder builder)
        {
            return builder
                .SetType()
                .SetLevel()
                .SetHealth()
                .SetDamage()
                .Build();
        }
    }
}
