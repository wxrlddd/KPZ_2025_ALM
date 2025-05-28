using System.Collections.Generic;
using Lab4.Task5.Models;

namespace Lab4.Task5.Models
{
    public class TextEditor
    {
        private readonly TextDocument _doc = new TextDocument();
        private readonly Stack<DocumentMemento> _history = new Stack<DocumentMemento>();

        public TextDocument Document => _doc;

        public void Type(string text)
        {
            _history.Push(_doc.Save());
            _doc.Append(text);
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var m = _history.Pop();
                _doc.Restore(m);
            }
        }
    }
}
