using System;
using System.Collections.Generic;

namespace Lab4.Task3.Models
{
    public class Element
    {
        public string TagName { get; }
        private readonly Dictionary<string, List<Action>> listeners = new Dictionary<string, List<Action>>(StringComparer.OrdinalIgnoreCase);

        public Element(string tagName)
        {
            TagName = tagName;
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

        public override string ToString() => $"<{TagName}>";
    }
}
