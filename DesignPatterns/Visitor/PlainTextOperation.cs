using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("text-Heading");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("text-Anchor");
        }
    }
}
