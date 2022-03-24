using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Protorype
{
    public class Text : IComponent
    {
        public string Content { get; set; }
        public Text(string content)
        {
            Content = content;
            //ShowContent();
        }

        public void ShowContent()
        {
            Console.WriteLine(Content);
        }

        public IComponent Clone()
        {
            return new Text(Content);
        }

        public void Show()
        {
            Console.WriteLine(Content);
        }
    }
}
