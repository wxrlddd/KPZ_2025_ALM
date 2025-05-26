namespace Lab3.Decorator
{
    public class ArtifactDecorator : HeroDecorator
    {
        public ArtifactDecorator(IHero hero, string artifact)
            : base(hero, "Артефакт: " + artifact) { }
    }
}