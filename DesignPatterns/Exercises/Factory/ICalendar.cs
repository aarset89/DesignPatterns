using System;

namespace DesignPatterns.Exercises.Factory
{
    public interface ICalendar
    {
        void AddEvent(Event event1, DateTime date);
    }
}