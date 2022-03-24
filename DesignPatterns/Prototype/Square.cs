using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Square : IComponent
    {
        public int Length { get; set; }
        public IComponent Clone()
        {
            var target = new Square();
            target.Length = Length;
            return target;
        }

        public void Render()
        {
            Console.WriteLine("Rendering Square");
        }
    }
}
