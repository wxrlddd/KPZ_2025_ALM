using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.Composite
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public bool IsSelfClosing { get; }
        public List<string> Classes { get; }
        public List<LightNode> Children { get; }

        public LightElementNode(string tagName,
                                bool isSelfClosing = false,
                                IEnumerable<string> cssClasses = null)
        {
            TagName = tagName;
            IsSelfClosing = isSelfClosing;
            Classes = (cssClasses != null)
                ? cssClasses.ToList()
                : new List<string>();
            Children = new List<LightNode>();
        }

        public void AddChild(LightNode child)
        {
            if (IsSelfClosing)
                return; // self-closing не може мати дітей
            Children.Add(child);
        }

        public override string InnerHTML()
        {
            var sb = new StringBuilder();
            foreach (var c in Children)
                sb.Append(c.OuterHTML());
            return sb.ToString();
        }

        public override string OuterHTML()
        {
            var sb = new StringBuilder();
            // Формуємо атрибут class, якщо є класи
            var classAttr = Classes.Any()
                ? $" class=\"{string.Join(" ", Classes)}\""
                : "";

            if (IsSelfClosing)
            {
                sb.Append($"<{TagName}{classAttr} />");
            }
            else
            {
                sb.Append($"<{TagName}{classAttr}>");
                sb.Append(InnerHTML());
                sb.Append($"</{TagName}>");
            }

            return sb.ToString();
        }
    }
}