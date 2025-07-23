using System;

namespace Abstraction
{
    public class CalendarEvent
    {
        public string Title { get; }
        public DateTime When { get; }
        public TimeSpan TimeUntil { get; }

        public CalendarEvent(string title, DateTime when)
        {
            Title = title;
            When = when;
            DateTime today = DateTime.Today;
            TimeSpan diff = when - today;
            if (diff.Ticks < 0)
            {
                Console.WriteLine("That date is already past.");
            }
        }


        public void Display()
        {
            Console.WriteLine($"\nEvent: {Title}");
            Console.WriteLine($"Date:  {When:dddd, MMMM d yyyy h:mm tt}");
        }
    }
}