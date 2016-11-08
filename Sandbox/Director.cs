using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Director : Manager
    {
        private int _bonus;
        private int _monthlyhours;

        public Director(string name, int salaryPerMonth, int monthlyhours, int bonus) : base(name, salaryPerMonth, monthlyhours, bonus)
        {
            _bonus = bonus + 2000;
            _monthlyhours = monthlyhours;

        }
    }
}
