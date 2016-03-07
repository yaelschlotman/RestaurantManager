using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Calendar
    {
        public string DayOpen { get; set; }
        public string Shift { get; set; }
        public string Hours { get; set; }

        public Calendar(string dayOpen, string shift, string hours)
        {
            this.DayOpen = dayOpen;
            this.Shift = shift;
            this.Hours = hours;
        }
    }
}
