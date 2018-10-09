using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintName()
        {
            Console.WriteLine(FirstName + "   " + LastName);
        }

        public static void Run()
        {
            Employee e1 = new Employee();
            Employee e2 = new FullTimeEmployee();
            Employee e3 = new PartTimeEmployee();


            e1.PrintName();
            e2.PrintName();
            e3.PrintName();

            Console.ReadKey();

        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintName()
        {
            Console.WriteLine(FirstName + "   " + LastName + "  FullTime");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintName()
        {
            Console.WriteLine(FirstName + "   " + LastName + "  PartTime");
        }
    }
}
