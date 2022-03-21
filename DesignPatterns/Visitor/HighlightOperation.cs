using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("Highlight-Heading");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("Highlight-Anchor");
        }
    }
}
