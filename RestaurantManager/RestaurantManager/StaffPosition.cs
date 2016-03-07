using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class StaffPosition
    {
        public string AssignStaffPosition()
        {
            string position = null;
            Console.WriteLine("Assign Staff Position: ");
            Console.WriteLine("(1) Waiter");
            Console.WriteLine("(2) Host");
            Console.WriteLine("(3) Busser");
            Console.WriteLine("(4) Cook");
            Console.WriteLine("(5) Dishwasher");
            Console.WriteLine("(6) Bartender");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                position = "Waiter";
            }
            else if (userChoice == "2")
            {
                position = "Host";
            }
            else if (userChoice == "3")
            {
                position = "Busser";
            }
            else if (userChoice == "4")
            {
                position = "Cook";
            }
            else if (userChoice == "5")
            {
                position = "Dishwasher";
            }
            else if (userChoice == "6")
            {
                position = "Bartender";
            }
            else
            {
                Console.WriteLine("Invalid entry.  Please choose number option.");
                AssignStaffPosition();
            }
            Console.WriteLine("Employee Position: " + position);
            
            return position;
        }
        private string Waiter;
        public string _waiter
        {
            get { return Waiter; }
            set { Waiter = value; }
        }
        private string Host;
        public string _host
        {
            get { return Host; }
            set { Host = value; }
        }
        private string Busser;
        public string _busser
        {
            get { return Busser; }
            set { Busser = value; }
        }
        private string Cook;
        public string _cook
        {
            get { return Cook; }
            set { Cook = value; }
        }
        private string Dishwasher;
        public string _dishwasher
        {
            get { return Dishwasher; }
            set { Dishwasher = value; }
        }
        private string Bartender;
        public string _bartender
        {
            get { return Bartender; }
            set { Bartender = value; }
        }

   





    }
}
