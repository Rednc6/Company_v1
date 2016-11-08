using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Worker wrk01 = new Worker("Truck Driver", "John", 10000);
            Console.WriteLine($"Name: {wrk01.GetName()} | Skill: {wrk01.getSkill()} | Salary: {wrk01.GetSalaryPerMonth()}");

            Manager mng01 = new Manager("Nameless one", 20000, 179, 1);
            Console.WriteLine(mng01.GetSalaryPerMonth());
            

            Director dir01 = new Director("Cthulhu", 50000, 179 , 1);
            Console.WriteLine(dir01.GetSalaryPerMonth());


            // Add you test of the Employee class and derived classes here



            // The LAST line of code should be ABOVE this line
        }
    }
}
