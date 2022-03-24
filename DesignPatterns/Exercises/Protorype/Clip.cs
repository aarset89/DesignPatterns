using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Protorype
{
    public class Clip : IComponent
    {
        public void Show()
        {
            Console.WriteLine("Showint Clip");
        }

        IComponent IComponent.Clone()
        {
            return new Clip();
        }
    }
}
