using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main()
        { 
            InputService input = new ConsoleInputService();
            string title = input.Read("Enter event title: ");
            DateTime when; 
            while (true) 
            { 
                string dateStr = input.Read("Enter event date & time (e.g. 2025-07-23 10:28): "); 
                if (DateTime.TryParse(dateStr, out when)) 
                    break;
                Console.WriteLine("Invalid format. Try again.");
            }

            var calEvent = new CalendarEvent(title, when); 
            calEvent.Display();
            Console.WriteLine("\nPress any key to exit..."); 
            Console.ReadKey();
            }
    }
}

