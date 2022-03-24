using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Protorype
{
    public class Audio : IComponent
    {
        public IComponent Clone()
        {
            return new Audio();
        }

        public void Show()
        {
            Console.WriteLine("Showing Audio");
        }
    }
}
