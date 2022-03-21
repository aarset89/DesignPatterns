using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public interface IOperation
    {
        void Apply(HeadingNode node);
        void Apply(AnchorNode node);
    }
}
