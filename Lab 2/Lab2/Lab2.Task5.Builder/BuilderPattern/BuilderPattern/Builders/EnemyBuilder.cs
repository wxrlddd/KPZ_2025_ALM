namespace BuilderPattern.Builders
{
    public abstract class EnemyBuilder
    {
        protected Enemy enemy = new Enemy();

        public abstract EnemyBuilder SetType();
        public abstract EnemyBuilder SetLevel();
        public abstract EnemyBuilder SetHealth();
        public abstract EnemyBuilder SetDamage();

        public Enemy Build() => enemy;
    }
}