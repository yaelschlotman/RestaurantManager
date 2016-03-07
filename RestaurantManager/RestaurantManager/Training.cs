using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Training
    {
        StaffPosition staffPosition = new StaffPosition();

        public bool SetTrainingByPosition()
        {
            string position = staffPosition.AssignStaffPosition();
            bool isTrained = false;
            switch (position)
            {
                case ("Bartender"):
                    bool knowsHouseDrinkRecipes;
                    Console.WriteLine("Has employee passed drink recipe test?" + Environment.NewLine +
                                       "(1) Yes   (2) No");
                    string userResponse1 = Console.ReadLine();
                    while (userResponse1 != null)
                    {
                        if (userResponse1 == "1")
                        {
                            knowsHouseDrinkRecipes = true;
                            isTrained = true;
                            Console.WriteLine("Employee ready for schedule.");
                            break;
                        }
                        else if (userResponse1 == "2")
                        {
                            Console.WriteLine("Employee not ready.  Continue training.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid response.");
                        }
                    }                    
                    break;
                case ("Busser"):
                    bool knowsTableClearing;
                    Console.WriteLine("Does employee know how to clear tables?" + Environment.NewLine +
                                       "(1) Yes   (2) No");
                    string userResponse2 = Console.ReadLine();
                    while (userResponse2 != null)
                    {
                        if (userResponse2 == "1")
                        {
                            knowsTableClearing = true;
                            isTrained = true;
                            Console.WriteLine("Employee ready for schedule.");
                            break;
                        }
                        else if (userResponse2 == "2")
                        {
                            Console.WriteLine("Employee not ready.  Continue training.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid response.");
                        }
                    }
                    break;
                case ("Waiter"):
                    bool canWaitTables;
                    Console.WriteLine("Can employee wait tables?" + Environment.NewLine +
                                       "(1) Yes   (2) No");
                    string userResponse3 = Console.ReadLine();
                    while (userResponse3 != null)
                    {
                        if (userResponse3 == "1")
                        {
                            canWaitTables = true;
                            isTrained = true;
                            Console.WriteLine("Employee ready for schedule.");
                            break;
                        }
                        else if (userResponse3 == "2")
                        {
                            Console.WriteLine("Employee not ready.  Continue training.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid response.");
                        }
                    }
                    break;
                case ("Host"):
                    bool knowsSeatingChart;
                    Console.WriteLine("Does employee know seating chart?" + Environment.NewLine +
                                       "(1) Yes   (2) No");
                    string userResponse4 = Console.ReadLine();
                    while (userResponse4 != null)
                    {
                        if (userResponse4 == "1")
                        {
                            knowsSeatingChart = true;
                            isTrained = true;
                            Console.WriteLine("Employee ready for schedule.");
                            break;
                        }
                        else if (userResponse4 == "2")
                        {
                            Console.WriteLine("Employee not ready.  Continue training.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid response.");
                        }
                    }
                    break;
                case ("Cook"):
                    bool knowsHouseFoodRecipes;
                    Console.WriteLine("Has employee passed food recipe test?" + Environment.NewLine +
                                       "(1) Yes   (2) No");
                    string userResponse5 = Console.ReadLine();
                    while (userResponse5 != null)
                    {
                        if (userResponse5 == "1")
                        {
                            knowsHouseFoodRecipes = true;
                            isTrained = true;
                            Console.WriteLine("Employee ready for schedule.");
                            break;
                        }
                        else if (userResponse5 == "2")
                        {
                            Console.WriteLine("Employee not ready.  Continue training.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid response.");
                        }
                    }
                    break;
                case ("Dishwasher"):
                    bool canWashDishes;
                    Console.WriteLine("Has employee passed drink recipe test?" + Environment.NewLine +
                                       "(1) Yes   (2) No");
                    string userResponse6 = Console.ReadLine();
                    while (userResponse6 != null)
                    {
                        if (userResponse6 == "1")
                        {
                            knowsHouseDrinkRecipes = true;
                            isTrained = true;
                            Console.WriteLine("Employee ready for schedule.");
                            break;
                        }
                        else if (userResponse6 == "2")
                        {
                            Console.WriteLine("Employee not ready.  Continue training.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid response.");
                        }
                    }
                    break;
            }
            return isTrained;
        }
    }
}
