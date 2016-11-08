using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {
        private int _bonus;
        
        public Manager(string name, int salaryPerMonth, int bonus) : base(name, salaryPerMonth)
        {
            _bonus = bonus;


        }

        public override int GetSalaryPerMonth()
        {
            return base.GetSalaryPerMonth() + _bonus;
        }
    }
}
