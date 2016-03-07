using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class StaffManagement 
    {
        HirirngCriteria hirirngCriteria = new HirirngCriteria();
        StaffPosition staffPosition = new StaffPosition();
        public Employee CreateNewEmployeeFile(string employeeName, string position, bool isHired, bool isTrained)
        {

            return (new Employee(employeeName, position, isHired, isTrained));
        }

        public void HireEmployee(string employeeName, string position, bool isHired, bool isTrained)
        {
            bool isEligibleForHire = hirirngCriteria.ScreenEmployee();
            if (isEligibleForHire == true)
            {
                isHired = true;
                CreateNewEmployeeFile(employeeName, position, isHired, isTrained);
            }
        }

        public List<Employee> CreateInitialStaff()
        {
            List<Employee> staffList = new List<Employee>();            
            staffList.Add(CreateNewEmployeeFile("Jenny", "Waiter", true, true));
            staffList.Add(CreateNewEmployeeFile("Melanie", "Host", true, true));
            staffList.Add(CreateNewEmployeeFile("Dawn", "Busser", true, true));
            staffList.Add(CreateNewEmployeeFile("Elaine", "Cook", true, true));
            staffList.Add(CreateNewEmployeeFile("Dee", "Dishwasher", true, true));
            staffList.Add(CreateNewEmployeeFile("Georgina", "Bartender", true, true));
            foreach (var employee in staffList)
            {
                Console.WriteLine(employee.EmployeeName + ",  " + employee.Position + ", Hired: " + employee.IsHired + ", Trained:" + employee.IsTrained);
            }
            return staffList;
        }
        public void FireEmployee()
        {
            Console.WriteLine("Fire Employee:  ");
            List<Employee> currentStaffList = CreateInitialStaff();
            List<Employee> firedEmployees = new List<Employee>();
            string userChoice;
            Console.WriteLine("Choose employee to fire by name:");
            userChoice = Console.ReadLine();
            foreach (Employee employee in currentStaffList)
            {
                if (userChoice == employee.EmployeeName)
                {
                    Console.WriteLine("Fire " + employee.EmployeeName + "?");
                    Console.WriteLine("Enter:  (1) Yes  (2) No");
                    string userDecision = Console.ReadLine();
                    if (userDecision != null && userDecision.ToLower() == "1")
                    {
                        firedEmployees.Add(employee);
                        currentStaffList.Remove(employee);
                        break;
                    }
                }
            }
            foreach (Employee employee in firedEmployees)
            {
                Console.WriteLine(employee.EmployeeName + ",  " + employee.Position + ", Fired ");
            }
            foreach (Employee employee in currentStaffList)
            {
                Console.WriteLine(employee.EmployeeName + ",  " + employee.Position + ", Hired: " + employee.IsHired + ", Trained:" + employee.IsTrained);
            }
        }
    }
}
