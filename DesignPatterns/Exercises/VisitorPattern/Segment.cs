using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.VisitorPattern
{
    public abstract class Segment
    {
        public abstract void ApplyFilter(IOperation operation);
        
    }
}
