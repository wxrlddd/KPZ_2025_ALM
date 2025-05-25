namespace BuilderPattern.Builders
{
    public class DragonBuilder : EnemyBuilder
    {
        public override EnemyBuilder SetType()
        {
            enemy.Type = "Дракон";
            return this;
        }

        public override EnemyBuilder SetLevel()
        {
            enemy.Level = 50;
            return this;
        }

        public override EnemyBuilder SetHealth()
        {
            enemy.Health = 500;
            return this;
        }

        public override EnemyBuilder SetDamage()
        {
            enemy.Damage = 80;
            return this;
        }
    }
}