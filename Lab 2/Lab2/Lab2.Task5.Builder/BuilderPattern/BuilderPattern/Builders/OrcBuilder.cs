namespace BuilderPattern.Builders
{
    public class OrcBuilder : EnemyBuilder
    {
        public override EnemyBuilder SetType()
        {
            enemy.Type = "Орк";
            return this;
        }

        public override EnemyBuilder SetLevel()
        {
            enemy.Level = 15;
            return this;
        }

        public override EnemyBuilder SetHealth()
        {
            enemy.Health = 120;
            return this;
        }

        public override EnemyBuilder SetDamage()
        {
            enemy.Damage = 25;
            return this;
        }
    }
}