using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oops
{
    public class Asynchronous
    {
        public string PrintAsync()
        {
            Task.Delay(5000);
            return "Hi! This is async method print";
        }

        public async void CallAsyncMethods()
        {
            Task<string> task = new Task<string>(PrintAsync);
            task.Start();
            Console.WriteLine("Task is running. Please wait...");
            string message = await task;
            Console.WriteLine("Task completed.");

            //Above or this is other way to write and run the task. with await task. combined and easy to write approach.
            //string message = await Task.Run(() => PrintAsync());

            Console.WriteLine(message);
        }
    }

    /// <summary>
    /// Using the volatile keyword in C# The volatile keyword in 
    /// C# is used to inform the JIT compiler that the value of the 
    /// variable should never be cached because it might be changed by the 
    /// operating system, the hardware, or a concurrently executing thread
    /// IMP** : Make sure you will run this in Release mode.
    /// </summary>
    public class VolatileConcept
    {
        //keeping volatile means every thread has it's local memory so volatile will 
        //update local memory copy of thread and main memory copy too. So to use volatile keyword.
        private volatile bool _loop = true;

        public void EntryFunction()
        {
            VolatileConcept obj = new VolatileConcept();
            Thread t1 = new Thread(SomeThread);
            t1.Start(obj);

            Thread.Sleep(20);

            obj._loop = false;
            Console.WriteLine("Step 2 : The value is set to false");
        }

        private static void SomeThread(object o1)
        {
            VolatileConcept o = (VolatileConcept)o1;
            Console.WriteLine("Step 1 : Entered the loop");

            while(o._loop)
            {

            }

            Console.WriteLine("Step 3 : Exited the while loop ");
        }
    }
}
