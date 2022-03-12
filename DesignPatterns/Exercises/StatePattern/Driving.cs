using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.StatePattern
{
    public class Driving : TravelMode
    {
        public void GetDirection()
        {
            Console.WriteLine("Calculating Direction (Driving)");
        }

        public void GetEta()
        {
            Console.WriteLine("Calculating ETA (Driving)");
        }
    }
}
