using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Mediator
{
    public class TextBox : UIControl
    {
        private string _content;

        public void SetContent(string content)
        {
            _content = content;
            NotifyObservers();
        }

        public string GetContent()
        {
            return _content;
        }

    }
}
