using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.VisitorPattern.Filters
{
    public class ReverbFilter : IOperation
    {
        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Applying ReverbFilter Filter to FactSegment");
        }

        public void Apply(FormatSegment formantSegment)
        {
            Console.WriteLine("Applying ReverbFilter Filter to FormatSegment");
        }
    }
}
