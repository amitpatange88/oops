using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Constructor
    {
        public void CallConstrcutorSeq()
        {
            Parent obj = new Child("mit");

        }
    }

    public class Parent
    {
        public string FullName = string.Empty;
        public static string CollegeName = string.Empty;

        static Parent()
        {
            Parent.CollegeName = "DY";
            Console.WriteLine("Static Parent.C");
        }

        public Parent()
        {
            Parent.CollegeName = "DY";
            this.FullName = "mit";
            Console.WriteLine("Parent.C");
        }

        public Parent(string Name)
        {
            Console.WriteLine("Parent.Param.C " + Name);
        }
    }

    public class Child : Parent
    {
        static Child()
        {
            Console.WriteLine("Static Child.C");
        }

        public Child() : base()
        {
            Console.WriteLine("Child.C");
        }

        public Child(string Name) //: base(Name)
        {
            Console.WriteLine("Child.Param.C " + Name);
        }
    }


    internal class TravelDia
    {
        //All access modifiers are allowed for constrcutors
        private TravelDia()
        {

        }
    }

    public  class AA
    {

    }

    public class BB : AA
    {


    }
}

/*
 * When We do like this : 
 * Parent obj = new Child("mit");
 * //output be like below :
 * -----------------------
 * Static Child.C
 * Static Parent.C
 * Parent.Param.C mit
 * Child.Param.C mit

     */
