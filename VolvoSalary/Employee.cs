using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoSalary
{
    internal abstract class Employee
    {
        //Employee field
        private string _name;
        private string _position;
        private string _socialSecurity;
        private int _yearEmployed;

        //Properties for the field above
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public string SocialSecurity
        {
            get { return _socialSecurity; }
            set { _socialSecurity = value; }
        }

        public int YearEmployed
        {
            get { return _yearEmployed; }
            set { _yearEmployed = value; }
        }

        //Abstrat method
        public abstract int CalculateSalary();

        public void updateSocialSecirity(string newSSN)
        {
            SocialSecurity = newSSN;
        }
    }
}
