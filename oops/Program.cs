using System;
using System.Threading;

namespace oops
{
    class Program
    {
        static void Main(string[] args)
        {
            //all oops concepts are implemented here.
            Multithreading();
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

        /// <summary>
        /// Runs program for multithreading.
        /// </summary>

        private static void Multithreading()
        {
            Multithread m1 = new Multithread();
            m1.TwoThreadedMethod();
            Console.ReadKey();
        }
    }

    
}
