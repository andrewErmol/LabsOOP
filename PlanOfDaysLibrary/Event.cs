using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EventsLibrary
{
    public class Event
    {
        public string Name;
        public DateTime DateOfEvent;
        public DaysOfWeek DayOfWeek;

        public Event(string events, string dateOfEvent, string dayOfWeek)
        {
            Name = events;
            DateOfEvent = DateTime.Parse(dateOfEvent);
            DayOfWeek = SetDay(dayOfWeek.Substring(0, 1).ToUpper() + dayOfWeek.Substring(1).ToLower());
        }
        
        public static DaysOfWeek SetDay(string dayOfWeek)
        {
            string day = dayOfWeek.Substring(0, 1);
            switch (dayOfWeek)
            {
                case "Monday":
                    return DaysOfWeek.Monday;
                case "Tuesday":
                    return DaysOfWeek.Tuesday;
                case "Wednesday":
                    return DaysOfWeek.Wednesday;
                case "Thursday":
                    return DaysOfWeek.Thursday;
                case "Friday":
                    return DaysOfWeek.Friday;
                case "Saturday":
                    return DaysOfWeek.Saturday;
                case "Sunday":
                    return DaysOfWeek.Sunday;
                default:
                    throw new Exception("Entered day of week do not exist");
            }
        }

    }
}
