using Lab3.Composite.LoadStrategies;

namespace Lab3.Composite
{
    public class LightImageNode : LightNode
    {
        private readonly string _href;
        private readonly ILoadStrategy _strategy;

        public LightImageNode(string href)
        {
            _href = href;
            // вибір стратегії залежно від префіксу
            if (href.StartsWith("http://") || href.StartsWith("https://"))
                _strategy = new WebLoadStrategy();
            else
                _strategy = new FileLoadStrategy();
        }

        public override string InnerHTML() => string.Empty;

        public override string OuterHTML()
        {
            // self-closing тег img з атрибутом src
            return $"<img src=\"{_href}\" />";
        }

        
        public void Load()
        {
            _strategy.Load(_href);
        }
    }
}
