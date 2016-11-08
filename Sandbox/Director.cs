using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Director : Manager
    {
        private int _bonus;

        public Director(string name, int salaryPerMonth, int bonus) : base(name, salaryPerMonth, bonus)
        {
            _bonus = bonus + 2000;

        }
    }
}
