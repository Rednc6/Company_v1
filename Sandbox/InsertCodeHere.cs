using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<Employee> workforce = new List<Employee>();


            Worker wrk01 = new Worker("Truck Driver", "John", 10000);
            // Console.WriteLine($"Name: {wrk01.GetName()} | Skill: {wrk01.getSkill()} | Salary: {wrk01.GetSalaryPerMonth()}");

            workforce.Add(wrk01);
            
            Manager mng01 = new Manager("Nameless one", 20000, 179, 1);
            mng01.sethours(2);

            workforce.Add(mng01);
            // Console.WriteLine(mng01.GetSalaryPerMonth());
            
            Director dir01 = new Director("Cthulhu", 50000, 179, 1);
            dir01.sethours(2);

            workforce.Add(dir01);

            foreach (var item in workforce)
            {
                Console.WriteLine($"Name: {item.GetName()} | Salary: {item.GetSalaryPerMonth()}");
            }

            // Console.WriteLine(dir01.GetSalaryPerMonth());


            // Add you test of the Employee class and derived classes here



            // The LAST line of code should be ABOVE this line
        }
    }
}
