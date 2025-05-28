using System;

namespace Lab3.Proxy
{
    // Проксі, що перевіряє текст на заборонені слова
    public class SmartTextChecker : ITextReader
    {
        private readonly ITextReader _inner;
        private readonly string[] _bannedWords = { "bad", "forbidden" };

        public SmartTextChecker(ITextReader inner) => _inner = inner;

        public string Read()
        {
            var text = _inner.Read();
            foreach (var word in _bannedWords)
            {
                // Для .NET, где нет Contains(string, StringComparison)
                if (text.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    throw new InvalidOperationException($"Текст містить заборонене слово: {word}");
            }
            return text;
        }
    }
}
