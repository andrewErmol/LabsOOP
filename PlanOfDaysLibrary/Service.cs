using EventsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanOfDaysLibrary
{
    public static class Service
    {
        public static List<Event> EventsList = new List<Event>();

        public static void AddEvent(string enterredEvent, string dateOfEvent, string dayOfWeek)
        {
            EventsList.Add(new Event(enterredEvent, dateOfEvent, dayOfWeek));
        }

        public static string CheckEventsOfEnteredDay(DateTime SpecifiedDate)
        {
            string result = "";

            for (int i = 0; i < EventsList.Count; i++)
            {
                if (EventsList[i].DateOfEvent == SpecifiedDate)
                {
                    result += $"{EventsList[i].Name}\n";
                }
            }

            return result;
        }

        public static string SpecifiedEventAfterSpecifiedDate(string specifiedEventName, DateTime specifiedDate)
        {
            string result = "";

            for (int i = 0; i < EventsList.Count; i++)
            {
                if (EventsList[i].Name == specifiedEventName && EventsList[i].DateOfEvent > specifiedDate)
                {
                    result += $"{EventsList[i].DateOfEvent.ToString("d")}\n";
                }
            }

            return result;
        }

        public static double AverageCountWithSpecifiedDayOfWeek(string day)
        {
            int countEventsInDayOfPlan = 0;

            DaysOfWeek dayOfWeek = Event.SetDay(day.Substring(0, 1).ToUpper() + day.Substring(1).ToLower());

            for (int i = 0; i < EventsList.Count; i++)
            {
                if (EventsList[i].DayOfWeek == dayOfWeek)
                {
                    countEventsInDayOfPlan++;
                }
            }

            Dictionary<DateTime, Event> eventByDaysDictionary = new Dictionary<DateTime, Event>();

            foreach (Event e in EventsList)
            {
                if (e.DayOfWeek == dayOfWeek && !eventByDaysDictionary.ContainsKey(e.DateOfEvent))
                {
                    eventByDaysDictionary.Add(e.DateOfEvent, e);
                }
            }

            return (countEventsInDayOfPlan / eventByDaysDictionary.Count);
        }
    }
}
