using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class HirirngCriteria
    {
        public bool IsDrugTestNegative;
        public bool IsBackgroundCheckClear;
        public bool IsEligibleForHire;
        public bool ScreenEmployee()
        {
            Console.WriteLine("Employment Pre-screening:");
            Console.WriteLine("Enter results of drug test:" + Environment.NewLine + 
                                "(1) Negative" + Environment.NewLine +
                                "(2) Positive");
            string userResponse1 = Console.ReadLine();
            if (userResponse1 == "1")
            {
                IsDrugTestNegative = true;
                Console.WriteLine("Enter results of background check:" + Environment.NewLine +
                                "(1) Clear" + Environment.NewLine +
                                "(2) Not Clear");
                string userResponse2 = Console.ReadLine();
                if (userResponse2 == "1")
                {
                    IsBackgroundCheckClear = true;
                    IsEligibleForHire = true;
                    Console.WriteLine("Applicant is eligible for hire.");
                }
                else
                {
                    Console.WriteLine("Applicant is not eligible for hire.");
                }
            }
            else if (userResponse1 == "2")
            {
                Console.WriteLine("Applicant is not eligible for hire.");
            }
            return IsEligibleForHire;
        }
    }
}
