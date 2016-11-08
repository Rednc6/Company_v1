using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {
        private int _bonus;
        private int _monthlyhours;
        
        public Manager(string name, int salaryPerMonth, int monthlyhours, int bonus) : base(name, salaryPerMonth)
        {
            _bonus = bonus;
            _monthlyhours = monthlyhours;
        }

        public override int GetSalaryPerMonth()
        {
            if (_monthlyhours >= 180)
            {
                return base.GetSalaryPerMonth() + _bonus;

            }
            else
            {
                return base.GetSalaryPerMonth();
            }
        }
        public void sethours(int hours)
        {
            hours = _monthlyhours;
            
        }
    }
}
