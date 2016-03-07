using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Employee
    {
        public string EmployeeName;
        public string Position;
        public bool IsHired;
        public bool IsTrained;

        public Employee(string employeeName, string position, bool isHired, bool isTrained)
        {
            this.EmployeeName = employeeName;
            this.Position = position;
            this.IsHired = isHired;
            this.IsTrained = isTrained;
        }

        public string _employeeName
        {
            get { return EmployeeName; }
        }
        public string _position
        {
            get { return Position; }
        }
        public bool _isHired
        {
            get { return IsHired; }
        }
        public bool _isTrained
        {
            get { return IsTrained; }
        }

    }
}
