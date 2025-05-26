namespace Lab3.Composite
{
    public class LightTextNode : LightNode
    {
        private readonly string _text;

        public LightTextNode(string text)
        {
            _text = text;
        }

        public override string InnerHTML()
        {
            // Текстовий вузол не має вкладених елементів
            return _text;
        }

        public override string OuterHTML()
        {
            // Outer == Inner для тексту
            return _text;
        }
    }
}