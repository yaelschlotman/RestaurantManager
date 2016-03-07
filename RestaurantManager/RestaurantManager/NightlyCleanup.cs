using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class NightlyCleanup
    {
        

        public List<string> CreateNightlyCleaningChecklist()
        {
            List<string> NightlyCleaningListByPosition = new List<string>();
            NightlyCleaningListByPosition.Add("Waiter:  Clean section");
            NightlyCleaningListByPosition.Add("Busser: Take out garbage.");
            NightlyCleaningListByPosition.Add("Host:  Tidy greeting station.");
            NightlyCleaningListByPosition.Add("Cook:  Clean grill.");
            NightlyCleaningListByPosition.Add("Dishwasher:  Finish all dishes.");
            NightlyCleaningListByPosition.Add("Bartender:  Clean up bar.");

            foreach (string item in NightlyCleaningListByPosition)
            {

                Console.WriteLine(item);
            }

            return NightlyCleaningListByPosition;
        } 
    }
}
