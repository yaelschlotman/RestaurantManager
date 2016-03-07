using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class Menu
    {
        public MenuItem CreateNewMenuItem(string itemName, string itemPrice)
        {
            return (new MenuItem(itemName, itemPrice));
        }
        public List<MenuItem> CreateSpecialsMenu()
        {
            List<MenuItem> specials = new List<MenuItem>();
            specials.Add(CreateNewMenuItem("Sunday: Chicken Sandwich", "$5.00"));
            specials.Add(CreateNewMenuItem("Monday: Hamburger", "$5.00"));
            specials.Add(CreateNewMenuItem("Tuesday: Veggie Pita", "$5.00"));
            specials.Add(CreateNewMenuItem("Wednesday: Onion Rings", "Free with any sandwich"));
            specials.Add(CreateNewMenuItem("Thursday: French Fries", "Free with any sandwich"));
            specials.Add(CreateNewMenuItem("Friday: Fish Sandwich", "$5.00"));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Daily Specials:");
            foreach (MenuItem special in specials)
            {
                Console.WriteLine(special.ItemName + ",  " + special.ItemPrice);
            }            
            return specials;
        }
        public List<MenuItem> CreateHappyHourMenu()
        {
            List<MenuItem> happyHourMenu = new List<MenuItem>();
            happyHourMenu.Add(CreateNewMenuItem("Endless Onion Rings", "$4.00"));
            happyHourMenu.Add(CreateNewMenuItem("Endless Onion Rings", "$4.00"));
            Console.WriteLine("***HAPPY HOUR SPECIALS***");
            Console.WriteLine("*****3pm - 5pm Daily*****");
            foreach (var special in happyHourMenu)
            {
                Console.WriteLine(special.ItemName + ",  " + special.ItemPrice);
            }
            return happyHourMenu;
        }
        public List<MenuItem> CreateFirstMenu()
        {
            List<MenuItem> menuList = new List<MenuItem>();
            menuList.Add(CreateNewMenuItem("Chicken Sandwich", "$6.00"));
            menuList.Add(CreateNewMenuItem("Hamburger", "$6.50"));
            menuList.Add(CreateNewMenuItem("Fish Sandwich", "$5.25"));
            menuList.Add(CreateNewMenuItem("Veggie Pita, ", "$5.50"));
            menuList.Add(CreateNewMenuItem("French Fries", "$2.00"));
            menuList.Add(CreateNewMenuItem("Onion Rings", "$3.00"));
            Console.WriteLine("MENU:");
            foreach (MenuItem menuItem in menuList)
            {
                Console.WriteLine(menuItem.ItemName + ",  " + menuItem.ItemPrice);
            }
            return menuList;
        }
    }
}
