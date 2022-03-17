using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class TextBox : UIControl
    {
        private string _content;
        //public TextBox(DialogBox owner) : base(owner)
        //{
        //}

        public string GetContent() => _content;
        public void SetContent(string content)
        {
            _content = content;
            //_owner.Changed(this);
            NotifyObservers();
        }

    }
}
