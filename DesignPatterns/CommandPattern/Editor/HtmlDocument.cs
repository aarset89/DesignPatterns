using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Editor
{
    public class HtmlDocument
    {
        private string _content;
        public void MakeBold() => _content = $"<b>{_content}</b>";

        public string GetContent() => _content;

        public void SetContent(string content) => _content = content;


    }
}
