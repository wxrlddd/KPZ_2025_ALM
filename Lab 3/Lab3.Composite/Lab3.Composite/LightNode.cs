namespace Lab3.Composite
{
    public abstract class LightNode
    {
        // Вміст між тегами
        public abstract string InnerHTML();

        // Увесь елемент з відкриваючим і закриваючим тегами (або self-closing)
        public abstract string OuterHTML();
    }
}