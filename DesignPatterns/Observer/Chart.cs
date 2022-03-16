using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Chart : Observer
    {
        public void Update()
        {
            Console.WriteLine("Chart updated");
        }
    }
}
