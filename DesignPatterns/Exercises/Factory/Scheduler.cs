using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Factory
{
    public class Scheduler
    {
        private ICalendar calendar;// = CreateCalendar();

        public Scheduler()
        {
            calendar = CreateCalendar();
        }

        public void Schedule(Event event1)
        {
            var t = new DateTime();
            calendar.AddEvent(event1, t);
        }

        protected virtual ICalendar CreateCalendar()
        {
            return new Calendar();
        }
    }
}
