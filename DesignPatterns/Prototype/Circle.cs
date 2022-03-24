using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Circle : IComponent
    {
        public int Radius { get; set; }
        public IComponent Clone()
        {
            var target = new Circle();
            target.Radius = Radius;

            return target;
        }

        public void Render()
        {
            Console.WriteLine("Rendering a Circle");
        }
    }
}
