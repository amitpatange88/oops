using Aopps.MethodOverriding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aopps
{

    public class Program
    {

        public static void Main(string[] args)
        {
            MethodOverloading ml = new MethodOverloading();
            // ml.Calculate();

            //Car c = new Car();
            //c.GetAirbags();

            //Bmw b = new Bmw();
            //b.GetAirbags();

            //Audi a = new Audi();
            //a.GetAirbags();

            //Car c1 = new Bmw();
            //c1.GetAirbags();

            //Car c2 = new Audi();
            //c2.GetAirbags();


            Student std1 = new Student();

            std1.StudentName = "Bill";

            Console.WriteLine(std1.StudentName);

            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);
            Console.ReadKey();

        }
        public static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
            Console.WriteLine(std2.StudentName);
        }
    }

    public class Student
    {
        public string StudentName { get; set; }
    }

}
