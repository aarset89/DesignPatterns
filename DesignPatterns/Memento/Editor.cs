using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Editor
    {
        private string Content;
        public void SetContent(string content)
        {
            Content = content;
        }
        public string GetContent()
        {
            return Content;
        }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState state)
        {
            Content = state.GetContent();
        }
    }
}
