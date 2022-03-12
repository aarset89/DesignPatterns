using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class EditorState
    {
        private string Content;
        public EditorState(string content)
        {
            Content = content;
        }

        public string GetContent()
        {
            return Content;
        }
    }
}
