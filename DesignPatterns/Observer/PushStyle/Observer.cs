using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.PushStyle
{
    public interface Observer
    {
        void Update(int value);
    }
}
