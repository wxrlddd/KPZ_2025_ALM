using Lab4.Task5.Models;

namespace Lab4.Task5.Models
{
    public class TextDocument
    {
        public string Content { get; private set; } = "";

        public void Append(string text)
        {
            Content += text;
        }

        public DocumentMemento Save()
        {
            return new DocumentMemento(Content);
        }

        public void Restore(DocumentMemento memento)
        {
            Content = memento.Content;
        }
    }
}
