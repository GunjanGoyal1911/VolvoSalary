using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoSalary
{
    internal class Manager : Employee
    {
        private List<Employee> _employeesManaged;
        private bool _isNightShift;


        public Manager(string name, string position, string socialSecurity, int yearEmployed,bool nightShift)
        {
            Name = name;
            Position = position;
            SocialSecurity = socialSecurity;
            YearEmployed = yearEmployed;
            _isNightShift= nightShift;
            _employeesManaged = new List<Employee>();   
        }

        //Properties for fields above

        public List<Employee> EmployeesManaged
        {
            get { return _employeesManaged; }
            set { _employeesManaged = value; }
        }
        public bool IsNightShift
        {
            get { return _isNightShift; }
            set { _isNightShift = value; }
        }
        //Method for adding employee to a manager
        public void AddEmployee(Employee employee)
        {
            _employeesManaged.Add(employee);
        }






        public override int CalculateSalary()
        {
            int employeeCountBonus = 1000;
            int baseSalary = SalaryHelper.BaseSalary(YearEmployed);
            int nightShiftBonus = SalaryHelper.NightShiftBonus(_isNightShift);
            int personalCount = employeeCountBonus * _employeesManaged.Count();
            int totalSalary = baseSalary + nightShiftBonus + personalCount;

            return totalSalary;
        }
    }
}
