using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.VisitorPattern
{
    internal interface FilterNode
    {
        void Execute(IOperation operation);
    }
}
