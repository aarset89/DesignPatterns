using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.IteratorPattern
{
    public interface Iterator
    {
        bool HasNext();
        Product Current();
        void Next();
    }
}
