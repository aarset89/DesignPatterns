using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.PushStyle
{
    public class Chart : Observer
    {
        public void Update(int value)
        {
            Console.WriteLine("Chart got updated" + value);

        }
    }
}
