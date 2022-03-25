using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Factory
{
    public class ArabicCalendar : ICalendar
    {
        public void AddEvent(Event event1, DateTime date)
        {
            Console.WriteLine("Adding event another calendar in the given date");
        }
    }
}
