using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Schedule
    {
        public Calendar CreateCalendarUnit(string dayOpen, string shift, string hours)
        {
            if (shift.ToLower() == "lunch")
            {
                hours = "11:00am-3:30pm";
            }
            else if (shift.ToLower() == "dinner")
            {
                hours = "4:00pm-10:00pm";
            }
            return (new Calendar(dayOpen, shift, hours));
        }

        public List<Calendar> SetSchedule()
        {
            List<Calendar> RestaurantSchedule = new List<Calendar>();
            RestaurantSchedule.Add(CreateCalendarUnit("Sunday", "Lunch", "11:00am-3:30pm"));
            RestaurantSchedule.Add(CreateCalendarUnit("Monday", "Lunch", "11:00am-3:30pm"));
            RestaurantSchedule.Add(CreateCalendarUnit("Tuesday", "Lunch", "11:00am-3:30pm"));
            RestaurantSchedule.Add(CreateCalendarUnit("Wednesday", "Lunch", "11:00am-3:30pm"));
            RestaurantSchedule.Add(CreateCalendarUnit("Thursday", "Lunch", "11:00am-3:30pm"));
            RestaurantSchedule.Add(CreateCalendarUnit("Friday", "Lunch", "11:00am-3:30pm"));
            RestaurantSchedule.Add(CreateCalendarUnit("Sunday", "Dinner", "4:00pm-10:00pm"));
            RestaurantSchedule.Add(CreateCalendarUnit("Monday", "Dinner", "4:00pm-10:00pm"));
            RestaurantSchedule.Add(CreateCalendarUnit("Tuesday", "Dinner", "4:00pm-10:00pm"));
            RestaurantSchedule.Add(CreateCalendarUnit("Wednesday", "Dinner", "4:00pm-10:00pm"));
            RestaurantSchedule.Add(CreateCalendarUnit("Thursday", "Dinner", "4:00pm-10:00pm"));

            Console.WriteLine(Environment.NewLine + "Hours of Operation:");
            foreach (var shift in RestaurantSchedule)
            {
                Console.WriteLine(shift.DayOpen + ":  " + shift.Shift + ", " + shift.Hours);
            }
            return RestaurantSchedule;
        }
    }
}
