using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class HighContrastFilter : IFilter
    {
        public void Apply()
        {
            Console.WriteLine("Filtering with High-Contrast");
        }
    }
}
