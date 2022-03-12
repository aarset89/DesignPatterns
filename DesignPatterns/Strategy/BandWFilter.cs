using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class BandWFilter : IFilter
    {
        public void Apply()
        {
            Console.WriteLine("Filtering with B&W");
        }

     }
}
