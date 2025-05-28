namespace Lab4.Task5.Models
{
    public class DocumentMemento
    {
        public string Content { get; }
        public DocumentMemento(string content)
        {
            Content = content;
        }
    }
}
