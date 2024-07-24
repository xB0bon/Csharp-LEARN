using System;

namespace Coding.Exercise
{
    public struct Event
    {
        public DateTime StartDate;
        public DateTime EndDate;

        public Event(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public double GetDuration()
        {
            return (EndDate - StartDate).TotalDays;
        }
        
        public bool IsOverlapping(Event otherEvent)
        {
            return StartDate <= otherEvent.EndDate && EndDate >= otherEvent.StartDate;
        }
    }

    public class Exercise
    {
        public void TestEvents()
        {
            Event event1 = new Event(new DateTime(2024, 7, 1), new DateTime(2024, 7, 10));
            Event event2 = new Event(new DateTime(2024, 7, 5), new DateTime(2024, 7, 15));
 
            // Print the duration of each event
            Console.WriteLine($"Event 1 Duration: {event1.GetDuration()} days");
            Console.WriteLine($"Event 2 Duration: {event2.GetDuration()} days");
 
            // Check and print whether the events overlap
            Console.WriteLine($"Events Overlap: {event1.IsOverlapping(event2)}");
        }
    }
}