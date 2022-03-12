using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Memento
{
    public class Document
    {
        private string Content;
        private string FontName;
        private int FontSize;

        public void SetContent(string content)
        {
            Content = content;
            
        }
        public string GetContent()
        {
            return Content;
        }

        public void SetFontName(string fontName)
        {
            FontName = fontName;
        }

        public string GetFontName()
        {
            return FontName;
        }

        public void SetFontSize(int fontSize)
        {
            FontSize = fontSize;
        }
        public DocumentState CreateState()
        {
            return new DocumentState(Content, FontName, FontSize);
        }

        public void Restore(DocumentState state)
        {
            Content = state.GetContent();
            FontName = state.GetFontName();
            FontSize = state.GetFontSize();
        }

        public string toString()
        {
            return "Document{" +
                    "content='" + Content + '\'' +
                    ", fontName='" + FontName + '\'' +
                    ", fontSize=" + FontSize +
                    '}';
        }
    }
}
