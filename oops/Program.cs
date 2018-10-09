using System;

namespace oops
{
    class Program
    {
        static void Main(string[] args)
        {
            //all oops concepts are implemented here.
            Program.RunVirtualOverideMethods();
        }
        
        /// <summary>
        /// This is an example Delegate. 
        /// </summary>
        private static void RunDelegate()
        {
            //Delegate Example demo.
            TestDelegate.CallDelegate();
        }

        /// <summary>
        /// Example of Virtual and Override methods. Basically we are doing polumorphism here.
        /// A base class reference variable can contain the child class object and invoke methods of that.
        /// </summary>
        private static void RunVirtualOverideMethods()
        {
            Employee.Run();
        }
    }
}
