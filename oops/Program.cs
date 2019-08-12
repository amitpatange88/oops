using System;
using System.Threading;

namespace oops
{
    /// <summary>
    /// Startup class i.e. Program
    /// </summary>
    public class Program //: BaseClass
    {
        //present in 7.3 c# version.
        //private protected string MyName = default(string);

        static void Main(string[] args)
        {
            //all oops concepts are implemented here.
            Console.WriteLine(System.Environment.MachineName);
            Console.WriteLine(System.Environment.UserName);
            Console.WriteLine(System.Environment.UserInteractive);

            //BaseClass baseObject = new BaseClass();
            //Program derivedObject = new Program();

            // Error CS1540, because myValue can only be accessed by
            // classes derived from BaseClass.
            //baseObject.myValue = 10;

            // OK, because this class derives from BaseClass.
            //derivedObject.myValue = 10;

            Console.ReadKey();
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
            ThreadAppDemo t = new ThreadAppDemo();
            t.RunDemo();

            Console.ReadKey();
        }

        private static void AsynchronousCall()
        {
            Asynchronous a = new Asynchronous();
            Console.WriteLine("Asynchronous call starts");
            a.CallAsyncMethods();
            Console.WriteLine("Asynchronous call ends");
            Console.ReadKey();
        }


        private static void VolatileTypeCall()
        {
            VolatileConcept v = new VolatileConcept();
            v.EntryFunction();
            Console.ReadKey();
        }

        private static void CallLinq()
        {
            Console.ReadKey();
        }


        /// <summary>
        /// Extension methods are static functions of a static class. These methods can be invoked just like instance method syntax.
        /// These methods are useful when we can not want to modify the class. Below is the example of Extension Method on string class.
        /// </summary>
        private static void ExtensionMethods()
        {
            string value = "malslfds";
            Console.WriteLine(value.IsStartWithLetterM()); //print true;

            Console.ReadLine();
        }


        /// <summary>
        /// Create threads using Task.Factory static method.
        /// </summary>
        private static void TaskFactoryRun()
        {
            ThreadAppDemo t = new ThreadAppDemo();
            t.InvokeTaskFactory();
        }

        private static void TupleUsage()
        {
            TupleUsage t = new oops.TupleUsage();
            t.CreateTuple();
        }

        private static void AnonymousTyesUsage()
        {
            AnonymousTypesUsage a = new oops.AnonymousTypesUsage();
            a.CreateAnonymous();
        }

        private static void YieldKeyword()
        {
            YieldKyeword.PrintList();
            Console.ReadKey();
        }

        private static void Indexers()
        {
            Indexers i = new Indexers();
            i.IndexerCaller();
            Console.ReadKey();
        }
    }

    
}
