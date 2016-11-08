using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
    {
        private string _skill;

        public Worker(string skill, string name, int salaryPerMonth) : base(name, salaryPerMonth)
        {
            this._skill = skill;

        } 
        public string getSkill()
        {
            return _skill;
        }

    }
}
