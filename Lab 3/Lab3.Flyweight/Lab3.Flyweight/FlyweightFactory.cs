using System.Collections.Generic;

namespace Lab3.Flyweight
{
    public static class FlyweightFactory
    {
        private static readonly Dictionary<string, string> _tags
            = new Dictionary<string, string>();
        private static readonly Dictionary<string, List<string>> _classLists
            = new Dictionary<string, List<string>>();

        public static string GetTag(string tagName)
        {
            string shared;
            if (!_tags.TryGetValue(tagName, out shared))
            {
                shared = tagName;
                _tags[tagName] = shared;
            }
            return shared;
        }

        public static List<string> GetClassList(IEnumerable<string> classes)
        {
            var key = classes != null
                ? string.Join(" ", classes)
                : string.Empty;

            List<string> shared;
            if (!_classLists.TryGetValue(key, out shared))
            {
                if (classes != null)
                    shared = new List<string>(classes);
                else
                    shared = new List<string>();
                _classLists[key] = shared;
            }
            return shared;
        }
    }
}
