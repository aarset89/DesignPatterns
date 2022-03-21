using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class HtmlDocument
    {
        private List<IHtmlNode> _node = new List<IHtmlNode>();

        public void AddNode(IHtmlNode node) => _node.Add(node);

        public void Execute(IOperation operation)
        {
            foreach(var node in _node)
                node.Execute(operation);
        }
    }
}
