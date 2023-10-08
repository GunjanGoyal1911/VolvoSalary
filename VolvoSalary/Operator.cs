using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoSalary 
{
    internal class Operator : Employee
    {
        //Fields for operator
        private int _hoursWorked;
        private bool _nightShift;
        private bool _drivesTruck;

        public Operator(string name, string position, string socialSerurity, int yearsEmployed, int hoursWored, bool nightShift, bool drivesTruck)
        {
            Name = name;
            Position = position;
            SocialSecurity= socialSerurity;
            YearEmployed = yearsEmployed;
            _hoursWorked = hoursWored;
            _nightShift = nightShift;
            _drivesTruck= drivesTruck;  

        }


        //properties for the fields above

        public int HoursWorked
        {
            get{ return _hoursWorked;}
            set{ _hoursWorked = value;}
        }

        public bool NightShift
        {
            get { return _nightShift; }
            set { _nightShift = value; }
        }

        public bool DrivesTruck
        {
            get { return _drivesTruck; }
            set { _drivesTruck = value; }
        }

        public override int CalculateSalary()
        {
            int baseSalary = SalaryHelper.BaseSalary(YearEmployed);
            int nightShiftBonus = SalaryHelper.NightShiftBonus(NightShift);
            int truckDriverBonus = SalaryHelper.TruckDriverBonus(DrivesTruck);
            int earningFromHours = SalaryHelper.EarningFromHours(HoursWorked);

            int totalSalary = baseSalary + nightShiftBonus + truckDriverBonus + earningFromHours;


            return totalSalary;
        }

        
    }
   
}
