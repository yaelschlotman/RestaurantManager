using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class UserView
    {
        Menu menu = new Menu();
        StaffManagement staff = new StaffManagement();
        IngredientInventory ingredientInventory = new IngredientInventory();
        Schedule schedule = new Schedule();
        NightlyCleanup nightlyCleanup = new NightlyCleanup();
        public string DisplayOptions()
        {
            Console.WriteLine(Environment.NewLine);         
            Console.WriteLine("Main Menu:" + Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("(1) Regular Daily Menu");
            Console.WriteLine("(2) Specials Menu");
            Console.WriteLine("(3) Happy Hour Menu");
            Console.WriteLine("(4) Staff List");
            Console.WriteLine("(5) Schedule");
            Console.WriteLine("(6) Inventory");
            Console.WriteLine("(7) Fire Employee");
            Console.WriteLine("(8) Nightly Cleaning Schedule");

            string userChoice = Console.ReadLine();
            return userChoice;
        }
        public void DisplayUserChoice()
        {
            string userChoice = DisplayOptions();
            switch (userChoice)
            {
                case ("1"):
                    menu.CreateFirstMenu();
                    DisplayUserChoice();
                    break;
                case ("2"):
                    menu.CreateSpecialsMenu();
                    DisplayUserChoice();
                    break;
                case ("3"):
                    menu.CreateHappyHourMenu();
                    DisplayUserChoice();
                    break;
                case ("4"):
                    staff.CreateInitialStaff();
                    DisplayUserChoice();
                    break;
                case ("5"):
                    schedule.SetSchedule();
                    DisplayUserChoice();
                    break;
                case ("6"):
                    ingredientInventory.TakeInventory();
                    DisplayUserChoice();
                    break;
                case ("7"):
                    staff.FireEmployee();
                    DisplayUserChoice();
                    break;
                case ("8"):
                    nightlyCleanup.CreateNightlyCleaningChecklist();
                    DisplayUserChoice();
                    break;
                default:
                    DisplayUserChoice();
                    break;

            }
        }


    }
}
