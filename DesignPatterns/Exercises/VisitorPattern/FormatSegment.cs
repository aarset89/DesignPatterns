using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.VisitorPattern
{
    public class FormatSegment : Segment
    {
        public override void ApplyFilter(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
