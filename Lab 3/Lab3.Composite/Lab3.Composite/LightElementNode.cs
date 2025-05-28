using System;
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

        private readonly Dictionary<string, List<Action>> listeners = new Dictionary<string, List<Action>>(StringComparer.OrdinalIgnoreCase);

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
                return;
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

        public void AddEventListener(string eventType, Action handler)
        {
            if (!listeners.TryGetValue(eventType, out var list))
            {
                list = new List<Action>();
                listeners[eventType] = list;
            }
            list.Add(handler);
        }

        public void DispatchEvent(string eventType)
        {
            if (listeners.TryGetValue(eventType, out var list))
                foreach (var h in list)
                    h();
        }
    }
}
