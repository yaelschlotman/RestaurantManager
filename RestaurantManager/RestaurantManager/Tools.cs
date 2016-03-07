using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Tools
    {
        public int CheckNumber()
        {
            int validNumber;
            string userInputNumber = Console.ReadLine();

            while (!int.TryParse(userInputNumber, out validNumber) )
            {
                Console.WriteLine("Invalid Entry.  Please enter a valid number.");
                userInputNumber = Console.ReadLine();
            }
            return validNumber;
        }

        
    }
}
