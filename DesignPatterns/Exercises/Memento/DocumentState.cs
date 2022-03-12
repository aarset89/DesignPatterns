using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Memento
{
    public class DocumentState
    {
        private string Content ;
        private string FontName;
        private int FontSize;

        public DocumentState(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }

        public string GetContent()
        {
            return Content;
        }
        public string GetFontName()
        {
            return FontName;
        }
        public int GetFontSize()
        {
            return FontSize;
        }
    }
}
