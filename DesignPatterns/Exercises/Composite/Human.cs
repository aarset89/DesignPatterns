using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Composite
{
    public class Human : IComponent
    {
        public void GoToEmergency()
        {
            Console.WriteLine("Humman going to Emergency");
        }
    }
}
