using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class Program
    {
        static void Main(string[] args)
        {
            UserView userView = new UserView();
            userView.DisplayUserChoice();

            Console.ReadKey();
        }
    }
}
