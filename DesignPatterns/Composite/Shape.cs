using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Shape : IComponent
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Shape");
        }
    }
}
