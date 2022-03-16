using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Editor
{
    public class BoldCommand : UndoableCommand
    {
        private string _prevContent;
        private HtmlDocument _document;
        private History _history;

        public BoldCommand(HtmlDocument document, History history)
        {
            _document = document;
            _history = history;
        }
        public void Execute()
        {
            _prevContent = _document.GetContent();

            _document.MakeBold();

            _history.Push(this);
        }

        public void Unexecute()
        {
            _document.SetContent(_prevContent);
        }
    }
}
