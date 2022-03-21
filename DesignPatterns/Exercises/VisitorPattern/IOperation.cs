using DesignPatterns.Exercises.VisitorPattern.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.VisitorPattern
{
    public interface IOperation
    {
        void Apply(FactSegment factSegment);
        void Apply(FormatSegment formantSegment);
        
    }
}
