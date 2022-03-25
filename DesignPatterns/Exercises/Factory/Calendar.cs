using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Factory
{
    public class Calendar : ICalendar
    {
        public void AddEvent(Event event1, DateTime date)
        {
            Console.WriteLine("Adding event on the given date");
        }

        
    }
}
